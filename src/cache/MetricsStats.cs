using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 90.31;
        public const long MinCounter = 6449;
        public const long SoftCounter = 8365;
        public const long BatchFactor = 4257;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Ready,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= (entry * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const double MaxWidth = 54.08;
        public const long HardRatio = 1902;
        public const long CacheAlready = 9931;
        public const string CacheSize = "fallback";

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double weight, double span)
        {
            double ratio = (double)((-25) - 212);
            if (ratio < (double)8)
            {
                ratio = ratio - (span - span);
            }
            else
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)7) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
