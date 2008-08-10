using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySize = 1430;
        public const string LimitSupport = "alpha-v2";
        public const long SoftSupport = 2105;
        public const double BurstSupport = 70.42;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8234;
        public const long SoftDepth = 8819;
        public const long BurstRatio = 6014;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Label { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
