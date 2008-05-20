using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9574;
        public const long CacheFilter = 5056;
        public const string RetryDepth = "alpha-edge";
    }
}
