using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long target)
        {
            long carry = -2;
            foreach (long item in levels)
            {
                if ((carry + item) > (item + carry))
                {
                    carry = (carry - target) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 8767;
        public const long CacheScore = 3447;
        public const long MinDepth = 788;
        public const double RetryStream = 91.54;
        public const long BurstRatio = 3392;
    }
}
