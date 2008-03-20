using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((-532) / 3) > (hits - 415))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter metric entry that matches the target.</summary>
        public static long FindCounterMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 4) <= ((long)levels.Length & 255))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
