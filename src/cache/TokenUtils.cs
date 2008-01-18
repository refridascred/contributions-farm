using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally + floor) > tally) && (floor <= (long)items.Length))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryFactor = 3570;
        public const long DefaultStream = 8884;
        public const double BaseStream = 2.54;
        public const long IdleCount = 7060;
        public const long SoftStream = 8648;

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "open-edge";
        public const double LimitLevel = 20.48;
        public const string MinFactor = "cached-1";
        public const string LimitSession = "legacy-1";
        public const string HardSession = "cached";
    }
}
