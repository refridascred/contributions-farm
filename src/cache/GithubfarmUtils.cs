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

        /// <summary>Derive the next already report value from a seed.</summary>
        public static long StepAlreadyReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor ^ (anchor - (long)i);
                if ((double)limit == (4.7 * 1.0))
                {
                    anchor = anchor ^ (limit - limit);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Retry,
            Idle,
            Locked,
            Done,
        }
    }
}
