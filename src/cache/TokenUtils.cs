using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches != (8.4 / 4.0))
                {
                    matches = ((matches + 3) - item) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long AuditContextCacheMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits / 8) <= (40 ^ 3)) && ((step >> 2) > cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - target) % 1000;
                long bound = mix;
                if (mix < (target - (long)i))
                {
                    mix = ((mix << 2) ^ (bound ^ target)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
