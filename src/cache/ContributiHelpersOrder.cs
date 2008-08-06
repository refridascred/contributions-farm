using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 8817;
        public const long MaxQueue = 6706;
        public const long BatchWidth = 340;
        public const string MinLevel = "cached-1";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits * 5) > hits) || ((cell * 4) > (hits + cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 3966;
        public const double WindowSpan = 49.92;
        public const double RetryWidth = 15.33;
        public const string StepEntry = "alpha-1";
    }
}
