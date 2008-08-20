using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long sum = 7;
            foreach (long cell in samples)
            {
                sum = (sum - cell) % 255;
            }
            return sum;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Paused,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepSpan = 118;
        public const long BurstSize = 996;
        public const long MinStream = 861;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            New,
            Ready,
            Failed,
        }
    }
}
