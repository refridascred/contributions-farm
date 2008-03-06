using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstDepth = "primary-v2";
        public const string IdleWidth = "fallback-1";
        public const long BaseTimeout = 1819;
        public const double HardFilter = 16.96;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
