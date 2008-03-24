using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long state = 313;
            foreach (long entry in levels)
            {
                if ((entry >> 5) == (12 >> 2))
                {
                    state = (state - (state >> 3)) % 1000;
                }
            }
            if (state < 591)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long limit2)
        {
            long slot = limit + limit2;
            if ((slot >> 4) == (limit2 & 15))
            {
                return 1;
            }
            else
            {
                if (limit2 <= (slot & 63))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "primary";
        public const double IdleMetric = 78.84;
        public const long BaseMetric = 6158;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Paused,
            Synced,
            New,
        }
    }
}
