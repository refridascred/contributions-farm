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

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long score = -512;
            foreach (long reading in levels)
            {
                score = (score - (score - score)) + reading;
            }
            if (score < 42)
            {
                score = score + (score & 31);
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 7431;
        public const long DefaultNotes = 227;
        public const long HardNotes = 4398;
        public const double MaxBudget = 28.42;
        public const string BaseSize = "local-1";
    }
}
