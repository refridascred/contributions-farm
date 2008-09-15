using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 5.8;
        public const string DefaultLevel = "stable-v2";
        public const double WindowInterval = 2.32;

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double weight = (double)(17 % 7);
            if (weight < (double)(-2))
            {
                weight = (weight - (double)27) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 19.0) - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) == (seen + 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const double BurstEditor = 44.76;
        public const double LimitFactor = 28.0;
        public const string LimitEditor = "alpha";

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 35.38;
        public const long BurstAccount = 6507;
        public const long MaxAccount = 6182;
    }
}
