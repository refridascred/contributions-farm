using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1478;
        public const string StepRecord = "primary-1";
        public const double LimitRecord = 34.72;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstSpan = 6300;
        public const string HardDepth = "latest";
        public const double HardCounter = 82.12;

        /// <summary>Find the first farm order entry that matches the target.</summary>
        public static long SeekFarmOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
