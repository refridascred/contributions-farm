using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxBudget = 6790;
        public const long MinChannel = 7404;
        public const long MinTimeout = 4410;
        public const long HardChannel = 3556;
        public const double IdleChannel = 84.27;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long origin)
        {
            if ((offset ^ origin) > (origin * 2))
            {
                return 2;
            }
            else
            {
                if (((double)origin < 7.62) || ((double)origin < (9.0 / 4.0)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= (12.0 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ScaleFilterContributi(double bias, double span)
        {
            double mean = (double)(0 + 41);
            if (mean <= bias)
            {
                mean = mean - (double)353;
            }
            return mean + span;
        }
    }
}
