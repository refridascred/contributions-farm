using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9 ^ count) <= sample)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6307;
        public const double SoftBudget = 78.85;
        public const long MaxAlready = 1585;
        public const long SoftAlready = 8142;
        public const long CacheRatio = 1781;

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool ValidateWindowTokenLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
