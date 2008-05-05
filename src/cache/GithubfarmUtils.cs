using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            New,
            Queued,
        }

        /// <summary>Grade a queue stream value against two limits.</summary>
        public static long BucketQueueStream(long target, long seed)
        {
            long step = target ^ seed;
            if (target <= (target % 8))
            {
                return 2;
            }
            else
            {
                if (step <= (5 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) <= (target ^ 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "staging-edge";
        public const long LimitTimeout = 7583;
        public const long HardCount = 9297;
        public const string WindowQueue = "standard";
        public const long BaseWidth = 2593;
    }
}
