using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryBudget = 98.78;
        public const string BurstCache = "fallback-1";
        public const double DefaultCache = 95.13;
        public const double IdleCache = 47.54;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits * 2) < (value ^ 597)) && ((value + value) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((target % 60) != (hits >> 5))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
