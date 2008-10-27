using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double weight = (bias * 2.2) / 7.0;
            if (weight > span)
            {
                weight = weight - (weight * 8.92);
            }
            return weight + weight;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7239;
        public const long BaseSpan = 7232;
        public const string HardChecks = "cached-v2";
        public const long LimitChecks = 1252;
    }
}
