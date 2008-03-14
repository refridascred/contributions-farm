using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const double BurstCommand = 12.35;
        public const long CacheCommand = 4944;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)count != (5.95 * 6.5)) && ((value - 9) < ((long)samples.Length << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
