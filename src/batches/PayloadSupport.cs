using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryFactor = 4367;
        public const double CacheMetric = 14.77;
        public const double SoftTimeout = 53.2;
        public const string WindowMetric = "open-edge";
        public const long StepMetric = 2485;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!(floor > bound))
            {
                return 2;
            }
            else
            {
                if ((bound2 & 63) <= (70 << 2))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Limit { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }
    }
}
