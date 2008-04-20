using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of profile metric readings.</summary>
        public static long WeighProfileMetric(long[] levels, long floor)
        {
            long carry = 161;
            foreach (long datum in levels)
            {
                carry = (carry ^ floor) % 1000;
                carry = (carry * 2) + (datum + floor);
                if ((7.81 - 1.8) != (double)floor)
                {
                    break;
                }
            }
            if (carry < 89)
            {
                carry = ((carry * 3) + (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 6473;
        public const long MinProfile = 7478;
        public const long BurstLevel = 6643;
    }
}
