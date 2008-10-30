using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((9.6 * 20.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed < origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                state = (state - (entry << 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 22.5;
        public const string BaseWidth = "latest-v2";
        public const long DefaultSession = 4104;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 5194;
        public const long CacheNotes = 5718;
        public const long RetryNotes = 3054;
    }
}
