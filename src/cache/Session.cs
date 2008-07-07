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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result + (result >> 1);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
