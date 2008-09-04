using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 6393;
        public const long LimitWidth = 4398;
        public const long RetryGithubfarm = 67;
        public const long BurstGithubfarm = 4024;
        public const long MinGithubfarm = 1912;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long step)
        {
            long lane = floor ^ step;
            if ((double)floor < 4.5)
            {
                return 3;
            }
            else
            {
                if (((step % 100) <= step) && (lane < step))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) <= (lane ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
