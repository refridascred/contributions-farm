using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCount = "legacy-1";
        public const long CacheDepth = 6452;
        public const string DefaultRatio = "staging-1";
        public const long CacheCluster = 7868;
        public const long BurstCluster = 6129;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the buffer queue series from a seed.</summary>
        public static long DeriveBufferQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor - anchor) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
