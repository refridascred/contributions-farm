using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the commits account series from a seed.</summary>
        public static long RollCommitsAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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
