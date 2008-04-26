using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long seed)
        {
            if ((bound - 8) > bound)
            {
                return 1;
            }
            else
            {
                if ((bound - 565) > (bound + seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            New,
            Draft,
            Locked,
        }
    }
}
