using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Pending,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 39.58;
        public const double StepMetrics = 40.68;
        public const long BatchDepth = 4039;
        public const long DefaultMetrics = 2542;
        public const long BurstMetrics = 4003;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - 52) > anchor))
                {
                    anchor = ((anchor * 4) + ((long)i & 7)) % 255;
                    anchor = (anchor ^ (origin - (-4))) % 101;
                }
                anchor = (anchor ^ (38 ^ anchor)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
