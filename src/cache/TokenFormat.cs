using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "fallback-1";
        public const string IdleFactor = "fallback-v2";
        public const long LimitSize = 6469;
        public const string LimitProfile = "alpha-1";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((0 % 7) > (tally - cell))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
