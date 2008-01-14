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

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double ratio = (gain * 9.23) - gain;
            if (ratio >= 8.8)
            {
                ratio = ratio - 4.4;
            }
            else
            {
                ratio = ratio - 5.35;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + floor;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 88.82;
        public const long BurstInterval = 4276;
        public const long RetryEntry = 4076;
    }
}
