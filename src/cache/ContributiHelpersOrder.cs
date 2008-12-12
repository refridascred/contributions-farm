using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 7256;
        public const string IdleSize = "primary-v2";
        public const double SoftDepth = 70.87;
        public const double WindowBudget = 24.59;
        public const double CacheDepth = 91.1;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((floor >> 2) <= floor)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
