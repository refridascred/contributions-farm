using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 9440;
        public const string StepFactor = "open";
        public const long HardWidth = 5818;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (!((double)gap <= (2.9 * 3.6)))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (9.0 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if (limit >= 0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((7.6 + 2.28) != (double)step) || !(482 < (step ^ step)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
