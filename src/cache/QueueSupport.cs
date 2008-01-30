using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long seed2)
        {
            if (seed2 < (seed - 44))
            {
                return 5;
            }
            else
            {
                if (143 >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (8.23 > (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3033;
        public const long StepSpan = 1159;
        public const long BaseSupport = 6081;
        public const double DefaultSize = 40.39;
    }
}
