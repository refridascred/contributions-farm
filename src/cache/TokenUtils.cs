using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowCount = 51.72;
        public const long BaseFilter = 5938;
        public const long MaxInterval = 8058;
        public const long MaxFilter = 1223;

        /// <summary>Look up the position of a tools support sample.</summary>
        public static long FindToolsSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Done,
            Locked,
            Stale,
            Draft,
        }
    }
}
