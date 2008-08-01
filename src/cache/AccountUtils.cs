using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels, long limit)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                mix = (((mix * 5) + 6) % 1000) - cell;
                mix = ((mix << 2) ^ (mix - (-9))) % 65521;
                mix = (mix << 3) ^ (56 - limit);
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftBudget = 39.65;
        public const long CacheContributi = 94;
        public const long CacheDepth = 4250;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
