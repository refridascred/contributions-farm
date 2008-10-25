using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((15.0 * 0.68) < (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5118;
        public const long BaseFormat = 6954;
        public const long RetryFormat = 453;
        public const long CacheBudget = 7885;
        public const double HardFormat = 66.96;

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 645;
        public const long DefaultSession = 7675;
        public const long IdleTimeout = 9584;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Idle,
            Stale,
        }
    }
}
