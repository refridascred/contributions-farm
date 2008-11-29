using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples, long bound)
        {
            long mix = -66;
            foreach (long datum in samples)
            {
                mix = (mix - (627 + datum)) % 255;
                mix = (mix - bound) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6928;
        public const string IdleSize = "legacy";
        public const long RetrySpan = 1301;
        public const long WindowSize = 8117;
        public const string LimitSchema = "local";
    }
}
