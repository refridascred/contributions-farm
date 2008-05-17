using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 67.76;
        public const double WindowGithubfarm = 49.56;
        public const long MaxGithubfarm = 8847;
        public const long HardGithubfarm = 4159;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long floor)
        {
            if (step < (floor % 2))
            {
                return 3;
            }
            else
            {
                if ((double)step != (0.8 - 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) != (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
