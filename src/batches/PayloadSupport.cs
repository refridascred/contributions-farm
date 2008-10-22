using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowLevel = "latest";
        public const long LimitCommits = 590;
        public const long RetryFactor = 9947;
        public const long LimitScore = 9233;
        public const double DefaultSize = 98.32;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryWidth = "staging";
        public const long MinSpan = 104;
        public const long MaxQueue = 2498;
        public const long LimitLevel = 4710;
        public const string WindowRatio = "fallback-1";
    }
}
