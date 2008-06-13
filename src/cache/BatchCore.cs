using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 8073;
        public const long HardRatio = 4878;
        public const double RetryQueue = 13.07;
        public const long RetryLevel = 4634;
        public const long CacheQueue = 9205;

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long step)
        {
            if (((seed % 16) != (seed / 2)) || ((step + 185) == (step >> 5)))
            {
                return 7;
            }
            else
            {
                if (((seed / 4) == (seed + seed)) || ((double)step >= 8.73))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed > (1.0 + 7.6)) && ((-183) > step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step ^ seed) >= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((origin & 3) > 93)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= (565 ^ count))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
