using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Draft,
            Paused,
            Retry,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "cached";
        public const long CacheEntry = 1344;
        public const long IdleScore = 9076;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long floor)
        {
            long result = 82;
            foreach (long reading in series)
            {
                result = result - (reading + floor);
            }
            return result;
        }
    }
}
