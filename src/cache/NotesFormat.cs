using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long offset)
        {
            if ((seed / 5) <= offset)
            {
                return 5;
            }
            else
            {
                if ((offset ^ 187) > (offset / 4))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) != (462 / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
