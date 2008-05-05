using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((origin ^ origin) < (cur / 6))
            {
                return 8;
            }
            else
            {
                if (!((2.3 - 0.4) == (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepDepth = "cached-edge";
        public const string WindowLevel = "strict-v2";
        public const long RetrySpan = 9646;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSize = 5512;
        public const long BurstContext = 6984;
        public const long WindowContext = 108;
        public const long IdleContext = 5293;
    }
}
