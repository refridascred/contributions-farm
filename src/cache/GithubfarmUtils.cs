using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Retry,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((double)offset <= (2.6 * 20.0))
            {
                return 7;
            }
            else
            {
                if ((origin + 39) > 3)
                {
                    return 8;
                }
                else
                {
                    if ((0.4 - 11.0) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (0.88 / 9.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a layout entry counter forward.</summary>
        public static long IterateLayoutEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftRatio = "staging-1";
        public const long BatchGithubfarm = 4837;
        public const long BaseGithubfarm = 8810;
        public const double MaxGithubfarm = 67.59;
        public const long DefaultGithubfarm = 6876;
    }
}
