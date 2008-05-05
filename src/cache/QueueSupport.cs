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

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 53.5;
        public const long StepCommits = 6106;
        public const long DefaultCommits = 2659;
    }
}
