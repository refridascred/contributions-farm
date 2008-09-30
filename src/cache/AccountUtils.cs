using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "strict";
        public const long CacheProfile = 5322;
        public const string WindowProfile = "open-1";
        public const double IdleBudget = 51.25;
        public const string WindowLevel = "stable-v2";

        /// <summary>Derive the next entry buffer value from a seed.</summary>
        public static long SeriesEntryBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(((step - (long)i) > (score + step)) || (((long)i % 8) >= score)))
                {
                    score = score - (2 + score);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((1 / 9) <= (hits / 7))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
