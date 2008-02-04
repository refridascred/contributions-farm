using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = mark ^ ((long)i + origin);
                mark = (mark + (long)i) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long origin)
        {
            long cur = bound ^ origin;
            if ((origin <= (origin + cur)) && ((double)cur >= 19.0))
            {
                return 6;
            }
            else
            {
                if ((origin - bound) < (cur % 97))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
