using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-1";
        public const string BatchFarm = "cached-v2";
        public const long MaxFarm = 3245;
        public const long BatchBudget = 5809;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 937;
        public const long HardCluster = 556;
        public const long IdleTimeout = 4716;
        public const long MaxCluster = 8852;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long seed, long limit)
        {
            long prev = seed - limit;
            if (((1.1 / 8.0) >= (double)seed) && ((8.05 + 18.0) >= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((seed - (-1)) >= prev)
                {
                    return 6;
                }
                else
                {
                    if ((seed + limit) <= (limit - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.8 - 9.65) < (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(2 <= (acc + bound)))
                {
                    acc = (acc * 4) + (bound + (long)i);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
