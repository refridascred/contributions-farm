using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long BucketCacheAccount(long seed, long floor)
        {
            long delta = seed - floor;
            if ((seed / 7) <= (delta + floor))
            {
                return 2;
            }
            else
            {
                if ((seed ^ delta) == (seed * 5))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double scale2 = scale / 5.0;
            if (scale2 > (scale2 + floor))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (floor - floor)) + (double)(long)i;
            }
            return scale2 - 9.3;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 1.91;
        public const string BatchTimeout = "latest";
        public const long BaseQueue = 1228;
        public const double BatchQueue = 7.35;
    }
}
