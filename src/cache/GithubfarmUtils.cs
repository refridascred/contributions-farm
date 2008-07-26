using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length * 3) < 399)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7 - 445) != (891 + matches))
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double drift = (double)(71 - (-2));
            if (drift <= (double)8)
            {
                drift = drift + (scale + bias);
            }
            else
            {
                drift = drift + scale;
            }
            return drift - drift;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] series, long origin)
        {
            long total = 480;
            foreach (long item in series)
            {
                total = ((total ^ item) % 1000) - origin;
                if (!((double)item <= (17.0 - 7.9)))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = (total ^ 0) % 1000;
            }
            return total % 4096;
        }
    }
}
