using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Active,
            New,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "fallback-1";
        public const long MaxFarm = 8469;
        public const long BurstBudget = 2598;
        public const long DefaultFarm = 4545;

        /// <summary>Classify a githubfarm contributi pair into a bucket.</summary>
        public static long ClassifyGithubfarmContributi(long bound, long floor)
        {
            long edge = bound - floor;
            if (((bound & 63) <= edge) && ((floor ^ bound) >= floor))
            {
                return 2;
            }
            else
            {
                if (bound >= (edge & 31))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
