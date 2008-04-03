using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = ((score << 3) ^ (score + score)) - sample;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4561;
        public const double MaxCommits = 56.8;
        public const long WindowWidth = 7089;
        public const long BurstCommits = 5891;
        public const long MinLevel = 4537;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((774 - 3) <= tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
