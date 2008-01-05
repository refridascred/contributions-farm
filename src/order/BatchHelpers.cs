using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 3714;
        public const long IdleLevel = 6035;
        public const long StepRatio = 2329;
        public const long HardStats = 2304;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 8901;
        public const double StepBuffer = 35.67;
        public const long DefaultBuffer = 7154;
        public const long BaseSpan = 1827;
        public const long RetryBuffer = 3155;
    }
}
