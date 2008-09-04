using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double bias2 = (weight + 14.0) * 2.0;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 + 14.0) - bias;
            }
            return bias2 + bias2;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long total = 336;
            foreach (long datum in series)
            {
                if (datum < total)
                {
                    total = (total << 3) ^ (datum / 2);
                }
                else
                {
                    total = (total + total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryTimeout = 6121;
        public const long DefaultBudget = 31;
        public const double MaxLevel = 91.49;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Pending,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 221;
        public const long MaxRatio = 9494;
        public const long BaseSupport = 9466;
        public const long HardTimeout = 4372;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - hits) < hits)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
