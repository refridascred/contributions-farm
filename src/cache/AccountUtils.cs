using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 8896;
        public const long BatchLevel = 2017;
        public const double WindowRatio = 77.78;
        public const string HardMetrics = "stable-1";

        /// <summary>Rank githubfarm farm input into a small class.</summary>
        public static long SortGithubfarmFarm(long floor, long target)
        {
            if ((floor ^ floor) == (target + target))
            {
                return 7;
            }
            else
            {
                if ((16.0 - 7.79) <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 2) >= (1 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
