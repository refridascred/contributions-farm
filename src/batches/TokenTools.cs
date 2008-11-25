using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 5082;
        public const string BaseWindow = "staging";
        public const string SoftWindow = "fallback-v2";
        public const string DefaultRatio = "primary-edge";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((step & 31) == (sample * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
