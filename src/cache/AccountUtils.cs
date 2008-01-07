using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long result = -797;
            foreach (long cell in items)
            {
                if ((1.0 - 8.3) == (double)cell)
                {
                    result = result + (cell * 4);
                }
            }
            return result % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 25.65;
        public const long DefaultSize = 4667;
        public const string HardChecks = "alpha";
    }
}
