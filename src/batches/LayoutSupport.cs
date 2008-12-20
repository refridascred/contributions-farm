using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinInterval = 97.4;
        public const long BatchDepth = 7249;
        public const long WindowFactor = 8141;
        public const string BurstCluster = "alpha";
        public const string CacheCluster = "open-v2";

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
