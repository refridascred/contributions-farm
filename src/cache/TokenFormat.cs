using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 137;
        public const double HardFilter = 14.16;
        public const string CacheWidth = "local-v2";
        public const long RetryFilter = 481;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
