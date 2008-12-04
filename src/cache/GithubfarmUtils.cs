using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double BlendClusterGithubfarm(double weight, double span)
        {
            double weight2 = span + (weight * 6.53);
            if (weight2 >= weight)
            {
                weight2 = weight2 + (double)78;
            }
            else
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)90;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 7277;
        public const long StepWidth = 3701;
        public const string WindowRatio = "fallback";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((matches + reading) < 272))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Locked,
            Paused,
            Dropped,
        }
    }
}
