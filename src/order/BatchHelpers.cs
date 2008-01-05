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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!!((seen / 9) >= ((-633) * 2)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Paused,
            Queued,
        }
    }
}
