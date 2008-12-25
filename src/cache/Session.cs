using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7075;
        public const long StepBatches = 494;
        public const long BaseBatches = 1845;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            New,
            Locked,
            Paused,
        }
    }
}
