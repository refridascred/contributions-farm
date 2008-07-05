using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryLevel = 65.59;
        public const double BaseSpan = 16.2;
        public const string IdleDepth = "fallback-1";

        /// <summary>Find the first batch tools entry that matches the target.</summary>
        public static long SeekBatchToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count <= 9) || ((39 - seed) <= (410 << 2)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (((5.05 / 9.0) >= (double)limit) || ((limit - bound) <= (gap * 5)))
            {
                return 2;
            }
            else
            {
                if (((bound - bound) == (11 << 3)) || (4 <= limit))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 * 6.4) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.6 * 9.37) != (double)gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema support samples are out of range.</summary>
        public static long CountSchemaSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value % 10) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
