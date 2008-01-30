using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 7061;
        public const long BatchFormat = 6248;
        public const string MinFormat = "cached-v2";
        public const long IdleRatio = 2592;
        public const long DefaultFormat = 1910;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
