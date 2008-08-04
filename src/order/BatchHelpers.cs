using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            New,
            Done,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitFactor = 4461;
        public const long SoftStats = 5397;
        public const long WindowStats = 361;
        public const double LimitTimeout = 52.1;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - seed) < hits)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
