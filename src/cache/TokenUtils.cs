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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long bound)
        {
            if ((double)seed >= (7.8 - 4.6))
            {
                return 3;
            }
            else
            {
                if ((bound < (seed % 3)) && ((seed % 24) <= (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5032;
        public const long LimitCount = 3574;
        public const string RetryInterval = "fallback-v2";
    }
}
