using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstLevel = "stable";
        public const long CacheScore = 6092;
        public const long BurstFilter = 9542;
        public const long BaseDepth = 212;
        public const double StepBudget = 56.0;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings)
        {
            long acc = 5;
            foreach (long cell in readings)
            {
                if ((cell + cell) <= acc)
                {
                    acc = (acc - ((long)readings.Length ^ acc)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double bias = (18.0 / 3.0) - (scale * 12.0);
            if (bias <= 4.54)
            {
                bias = bias - floor;
            }
            return bias + (double)87;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Ready,
            Idle,
            Synced,
        }
    }
}
