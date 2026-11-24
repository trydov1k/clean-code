namespace Markdown.Abstractions;

public interface ITagParser
{
    /// <returns>
    /// true, если текущий фрагмент поглощён и цикл должен перейти
    /// к следующей итерации; false, если текущий символ ещё нужно обработать.
    /// </returns>
    bool TryParse(ref int currentPosition);
}