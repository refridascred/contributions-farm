using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1091;
        public const double BatchChecks = 75.11;
        public const long BaseSpan = 3309;
        public const string RetrySize = "fallback-1";
        public const string LimitCount = "strict-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha";
        public const long DefaultFormat = 9563;
        public const long RetryFormat = 5628;

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
