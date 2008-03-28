using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long score = 804;
            foreach (long sample in series)
            {
                if ((sample % 2) > score)
                {
                    score = score - (score << 3);
                }
            }
            return score;
        }

        /// <summary>Blend two notes stats measurements.</summary>
        public static double BlendNotesStats(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 + (8.96 / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - scale) - (double)(long)i;
            }
            return bias2 + 8.67;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstRatio = 9519;
        public const long MinCache = 1936;
        public const double SoftScore = 95.51;
    }
}
