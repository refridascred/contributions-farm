using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total - bound) % 1000) ^ (long)i2;
                }
                total = (total - (total * 2)) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (seed >= (22 - offset2))
            {
                return 2;
            }
            else
            {
                if (((offset2 + seed) >= (offset << 2)) && ((offset2 ^ 81) > seed))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long seed, long offset)
        {
            if (525 <= (seed * 2))
            {
                return 7;
            }
            else
            {
                if (!((seed - offset) <= (84 / 2)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.1 + 3.0)) && ((double)tally <= (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            if ((3.0 - 7.1) >= (5.5 - 6.81))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 / 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
