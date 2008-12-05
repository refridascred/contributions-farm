using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 63.58;
        public const long RetryRecord = 6258;
        public const long MaxRecord = 7094;
        public const double HardRecord = 24.98;
        public const double HardCount = 25.09;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Paused,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((limit % 24) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed < (7.0 * 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
