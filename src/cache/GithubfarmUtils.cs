using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if (!((bound & 7) <= (step ^ bound)))
            {
                return 8;
            }
            else
            {
                if ((step + step) >= (bound - step))
                {
                    return 5;
                }
                else
                {
                    if (19 < (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 6561;
        public const long RetryWindow = 2427;
        public const long MaxInterval = 1859;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Done,
            Locked,
        }
    }
}
