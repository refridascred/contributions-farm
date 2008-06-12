using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "primary";
        public const long MaxRatio = 5396;
        public const long RetrySize = 5267;
        public const string IdleToken = "cached-v2";
        public const double MinToken = 92.52;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 9651;
        public const long LimitSpan = 2922;
        public const long MinCount = 355;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 2645;
        public const long BurstBuffer = 4936;
        public const long DefaultBuffer = 993;
        public const long LimitBuffer = 5663;
        public const long SoftRatio = 3201;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (8.2 * 5.7))
                {
                    matches = ((matches + 3) + sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
