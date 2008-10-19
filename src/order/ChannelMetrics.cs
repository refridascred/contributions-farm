using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Closed,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinDepth = "local-edge";
        public const long BaseProfile = 6551;
        public const long CacheDepth = 260;
        public const long DefaultFactor = 3378;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings)
        {
            long anchor = 826;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 2) ^ (9 - reading)) % 101;
            }
            if (anchor > 33)
            {
                anchor = (anchor ^ (334 + anchor)) % 101;
            }
            return anchor;
        }
    }
}
