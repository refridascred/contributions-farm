using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if (step < 671)
            {
                return 1;
            }
            else
            {
                if ((91 - step) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 8.6)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (1.0 + 6.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7027;
        public const string MaxCluster = "local";
        public const long HardDepth = 3958;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
