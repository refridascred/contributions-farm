using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "strict-edge";
        public const long DefaultWidth = 4558;
        public const long BatchChecks = 556;
        public const long SoftChecks = 108;
        public const long BaseSize = 1300;

        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long TallyMetricsGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (643 < (tally - 88))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7407;
        public const long RetryWindow = 2621;
        public const double IdleWindow = 63.01;
        public const long MaxWindow = 6111;
        public const long SoftFactor = 4863;
    }
}
