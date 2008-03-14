using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
