using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long step)
        {
            long delta = target ^ step;
            if (((8.7 * 4.0) != (double)delta) || ((delta * 3) != (target ^ delta)))
            {
                return 5;
            }
            else
            {
                if (((step & 7) >= step) && ((target + 999) <= (step + target)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 8079;
        public const long BaseDepth = 3570;
        public const double SoftWidth = 23.22;
        public const long MinPayload = 9643;
        public const long MaxPayload = 5788;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6200;
        public const long HardSchema = 6188;
        public const string CacheDepth = "standard-edge";
    }
}
