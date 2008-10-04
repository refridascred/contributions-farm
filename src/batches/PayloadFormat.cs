using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstLevel = 4411;
        public const long BurstScore = 2332;
        public const long MaxBatches = 9878;
        public const long HardBatches = 2228;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Pending,
            Dropped,
            Stale,
            Failed,
        }
    }
}
