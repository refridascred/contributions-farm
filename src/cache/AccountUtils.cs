using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((7.4 * 6.0) > (double)offset)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2258;
        public const long StepSize = 8189;
        public const long LimitDepth = 2344;
    }
}
