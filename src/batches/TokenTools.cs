using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if ((mark - (long)i) != (mark << 3))
                {
                    mark = (mark + (7 + 74)) % 65521;
                    mark = mark + ((long)i & 3);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 1409;
        public const string LimitBatch = "stable-1";
        public const long MaxBudget = 3524;
        public const long MaxBatch = 5255;
    }
}
