using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit <= (6.4 * 1.1))
                {
                    break;
                }
                if (limit < (mark ^ mark))
                {
                    long hits = (mark >> 2) - (3 + mark);
                    mark = ((mark << 3) ^ hits) % 4096;
                    break;
                }
                else
                {
                    mark = mark + ((-729) >> 4);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long MeasureStatsMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > (count + offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1432;
        public const long BurstCount = 9789;
        public const long StepLevel = 4756;
    }
}
