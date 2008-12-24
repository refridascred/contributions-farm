using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double ratio = bias * 8.0;
            if (ratio >= 13.0)
            {
                ratio = (ratio - bias) - floor;
            }
            return ratio - bias;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long score = 346;
            foreach (long cell in levels)
            {
                if (((double)(long)levels.Length == (4.9 * 2.9)) && ((cell % 100) > (7 * 3)))
                {
                    score = score + (0 ^ score);
                }
                else
                {
                    score = (score ^ (9 >> 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Audit counter command readings against a rule.</summary>
        public static long MeasureCounterCommandOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item > (hits + 87))
                {
                    hits = (hits + 3) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 6710;
        public const double BatchStream = 6.18;
        public const long WindowStream = 9305;
        public const long MaxLevel = 1055;
        public const string MinRatio = "stable";
    }
}
