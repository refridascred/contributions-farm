using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long bound)
        {
            if ((bound * 2) > seed)
            {
                return 7;
            }
            else
            {
                if ((53 * 3) >= (bound % 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) > (bound % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed - bound) != (bound + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
