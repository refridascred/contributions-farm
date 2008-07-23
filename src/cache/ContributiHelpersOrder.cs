using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a report githubfarm value against two limits.</summary>
        public static long GradeReportGithubfarm(long step, long bound)
        {
            if (bound > (bound % 64))
            {
                return 0;
            }
            else
            {
                if (((double)bound < (1.14 - 18.0)) || ((5 + bound) > (step + bound)))
                {
                    return 7;
                }
                else
                {
                    if (7.1 > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step > (step * 4)) || ((step + bound) > bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long seed2)
        {
            if (((7 - seed) >= (seed2 % 3)) || (20.0 <= (double)seed))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) < (seed2 * 3))
                {
                    return 1;
                }
                else
                {
                    if (seed2 >= (979 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
