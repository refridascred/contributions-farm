using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long seed)
        {
            long step = floor + seed;
            if (seed <= (seed - step))
            {
                return 4;
            }
            else
            {
                if ((seed ^ seed) != (floor & 63))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (14.0 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 8957;
        public const double MaxWidth = 82.73;
        public const long CacheScore = 5566;
    }
}
