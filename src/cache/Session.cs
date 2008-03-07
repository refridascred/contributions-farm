using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "cached-v2";
        public const long WindowTimeout = 9333;
        public const long MaxSpan = 8173;
        public const string SoftStream = "open-edge";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long state = 345;
            foreach (long item in levels)
            {
                if ((item / 4) == (state - state))
                {
                    state = (state << 2) ^ (14 ^ state);
                }
            }
            return state % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 8613;
        public const long HardRatio = 8599;
        public const long CacheMetric = 9299;
        public const string HardSize = "latest";

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "latest-1";
        public const long StepDepth = 5472;
        public const long LimitCommits = 3138;
    }
}
