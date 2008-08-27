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

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 3594;
        public const double MinAlready = 36.88;
        public const string MinCount = "stable-edge";

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
