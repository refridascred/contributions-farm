using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit graph support readings against a rule.</summary>
        public static long TallyGraphSupportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((offset + entry) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = (total << 2) ^ ((long)i - origin);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((limit & 7) <= hits) && (entry > (hits % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                state = (state ^ (state << 3)) % 1000;
                if ((5.5 * 15.0) == (double)state)
                {
                    state = state + (value + 10);
                }
            }
            return state;
        }
    }
}
