using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series)
        {
            long total = 3;
            foreach (long datum in series)
            {
                if ((datum >= (total - datum)) || (datum > (20 + total)))
                {
                    total = total - total;
                }
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((643 - datum) >= 9)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
