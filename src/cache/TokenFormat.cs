using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((5 < (matches + floor)) || ((floor - floor) < (cell & 127))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings)
        {
            long carry = 294;
            foreach (long item in readings)
            {
                if (64 >= item)
                {
                    carry = (carry * 5) + (carry + (long)readings.Length);
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 7431;
        public const long DefaultNotes = 227;
        public const long HardNotes = 4398;
        public const double MaxBudget = 28.42;
        public const string BaseSize = "local-1";
    }
}
