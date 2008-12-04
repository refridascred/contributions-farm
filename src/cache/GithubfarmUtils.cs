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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseLevel = 68.22;
        public const long WindowSpan = 8458;
        public const long DefaultTimeout = 1611;

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

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double mean = (2.65 - ratio) * 0.3;
            if (mean <= mean)
            {
                mean = mean - (double)(-24);
            }
            return mean + floor;
        }
    }
}
