using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 4344;
        public const long WindowCommits = 3797;
        public const long SoftCommits = 6621;
        public const long HardBudget = 9349;
        public const double CacheSize = 30.16;

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseWidth = 80.5;
        public const long SoftCount = 3546;
        public const double BurstTimeout = 33.91;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally / 2) == (item - tally))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
