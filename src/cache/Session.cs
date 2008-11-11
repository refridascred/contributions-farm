using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == ((-49) + 439))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitLevel = 3993;
        public const double DefaultSize = 51.13;
        public const string DefaultContext = "local-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSpan = 3410;
        public const string IdleWidth = "standard";
        public const long StepScore = 8769;
        public const double MinMetric = 85.64;
        public const long LimitRatio = 9901;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 117) != (floor % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
