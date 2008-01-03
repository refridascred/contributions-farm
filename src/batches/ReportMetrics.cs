using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                long hits = 74 & 127;
                score = (score << 3) ^ score;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 1000;
                    score = score - hits;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (weight * 2.9))
            {
                weight = weight - (weight - floor);
            }
            else
            {
                weight = weight + rate;
            }
            return weight - weight;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 8155;
        public const long LimitScore = 401;
        public const long StepScore = 7374;
        public const string LimitRecord = "open-1";
    }
}
