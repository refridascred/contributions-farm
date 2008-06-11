using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstLevel = 5509;
        public const double IdleEntry = 16.46;
        public const long BurstEntry = 5275;
        public const string StepEntry = "fallback";
        public const string CacheSize = "primary-1";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((13.0 * 6.08) >= (double)floor)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Done,
            Ready,
            New,
        }
    }
}
