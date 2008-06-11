using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Done,
            Stale,
            Ready,
            Failed,
        }

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
