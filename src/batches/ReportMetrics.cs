using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double bias = (double)(212 % 12);
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (weight + span)) + (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchWidth = 47.61;
        public const long BatchQueue = 5716;
        public const long LimitRatio = 683;
        public const long WindowCount = 5473;
    }
}
