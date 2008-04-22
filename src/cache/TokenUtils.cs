using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((9.67 - 10.0) < (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (double)265) + (double)(long)i) - ratio;
            }
            return rate - (double)82;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
