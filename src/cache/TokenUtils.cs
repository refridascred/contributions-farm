using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((7.0 * 16.0) <= (double)matches)
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5032;
        public const long LimitCount = 3574;
        public const string RetryInterval = "fallback-v2";
    }
}
