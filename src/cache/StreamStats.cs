using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((3.29 - 1.85) < (double)count)
                {
                    count = ((count + 1) ^ sample) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound - step) > (bound >> 3))
            {
                return 6;
            }
            else
            {
                if (((limit / 8) > 41) && ((double)675 <= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((5.5 + 1.9) >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two cache format measurements.</summary>
        public static double BlendCacheFormat(double ratio, double bias)
        {
            double mean = bias;
            return (mean - (4.08 - mean)) + ratio;
        }
    }
}
