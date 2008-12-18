using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long offset)
        {
            long anchor = 36;
            foreach (long sample in data)
            {
                if (!(offset > sample))
                {
                    anchor = (anchor * 2) + offset;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor ^ (anchor + offset)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseLevel = 13.67;
        public const double HardSession = 62.98;
        public const long BurstSize = 8739;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
