using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample ^ hits) < sample)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Draft,
            Idle,
            Retry,
        }
    }
}
