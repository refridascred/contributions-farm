using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits buffer readings against a rule.</summary>
        public static long MeasureCommitsBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(matches < (matches + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowScore = 7279;
        public const double HardRatio = 51.09;
        public const long BatchScore = 1166;
        public const double MaxGraph = 18.73;
        public const double LimitGraph = 50.18;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
