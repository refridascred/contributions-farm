using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((step - step) <= (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long floor)
        {
            long score = 370;
            foreach (long item in readings)
            {
                if (floor < (7 - floor))
                {
                    score = (score + (item * 3)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 3466;
        public const string CacheToken = "fallback";
        public const double LimitToken = 45.01;
    }
}
