using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the stats contributi entries that pass the check.</summary>
        public static long CountStatsContributiMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((4.57 + 7.17) >= (double)(long)readings.Length)
                {
                    seen = ((seen + 2) - item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long seed, long seed2)
        {
            long prev = seed - seed2;
            if ((seed2 * 4) >= (seed2 - prev))
            {
                return 8;
            }
            else
            {
                if ((5 - seed) >= (seed2 >> 1))
                {
                    return 3;
                }
                else
                {
                    if (seed < (117 - seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long mark = 676;
            foreach (long cell in items)
            {
                if ((cell + mark) >= mark)
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = ((mark * 5) + (mark - 85)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
