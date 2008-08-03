using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long AuditWindowBatchesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((435 + tally) <= 331)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 28.03;
        public const double DefaultDepth = 20.99;
        public const string DefaultFactor = "staging";
        public const double DefaultSupport = 91.77;
    }
}
