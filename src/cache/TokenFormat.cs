using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultTimeout = 8.17;
        public const long BaseBudget = 75;
        public const long HardCluster = 104;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long limit2)
        {
            if ((limit2 << 1) < 99)
            {
                return 0;
            }
            else
            {
                if ((1 - limit2) > (limit2 - (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) >= (810 % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
