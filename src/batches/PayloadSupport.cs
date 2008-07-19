using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 8570;
        public const long IdleSpan = 6043;
        public const string WindowSize = "fallback-edge";
        public const long RetryLayout = 1416;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3853;
        public const double MinToken = 85.71;
        public const long CacheToken = 8417;
    }
}
