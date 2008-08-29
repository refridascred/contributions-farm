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

        /// <summary>Fold a list of route format readings.</summary>
        public static long DigestRouteFormat(long[] series, long target)
        {
            long carry = 214;
            foreach (long item in series)
            {
                carry = carry - (target + (-163));
                if (!((item - carry) == (carry - carry)))
                {
                    break;
                }
            }
            if (carry > (-72))
            {
                carry = (carry + (target >> 1)) % 101;
            }
            return carry;
        }
    }
}
