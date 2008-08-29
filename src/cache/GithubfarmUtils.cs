using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (offset < (reading % 97))
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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long total = 556;
            foreach (long cell in series)
            {
                if ((cell + cell) >= total)
                {
                    total = ((total * 5) + total) % 65521;
                }
                else
                {
                    total = (total - cell) % 255;
                }
                if (cell >= (cell << 1))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + cell) != (cell >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleFactor = 475;
        public const long MaxTimeout = 5472;
        public const string BaseWidth = "local-v2";
        public const long BaseRatio = 561;
    }
}
