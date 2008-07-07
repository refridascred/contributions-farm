using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 2384;
        public const string CacheDepth = "legacy-1";
        public const double RetryStream = 83.53;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long offset)
        {
            long lane = seed + offset;
            if ((offset << 1) <= 0)
            {
                return 8;
            }
            else
            {
                if ((((-4) << 2) == (lane + 6)) || ((double)seed <= (6.3 * 4.98)))
                {
                    return 4;
                }
                else
                {
                    if ((lane ^ seed) >= offset)
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

        /// <summary>Audit context queue readings against a rule.</summary>
        public static long MeasureContextQueueGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - floor) >= (floor << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)88;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (ratio + ratio)) - (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
