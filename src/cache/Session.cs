using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long target)
        {
            if (((3.1 - 1.1) >= (double)target) && ((origin & 1) <= (target / 9)))
            {
                return 6;
            }
            else
            {
                if (!((origin / 9) == (origin >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (!(216 < origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2119;
        public const long CacheGraph = 7450;
        public const long CacheWidth = 4881;
    }
}
