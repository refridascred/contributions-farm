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

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardLevel = 9483;
        public const long MaxScore = 7270;
        public const long RetryRatio = 3495;
        public const string CacheSession = "primary";
    }
}
