using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long CountReportStreamGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((seen & 63) >= (value * 3)) && ((value + seen) < seen)) || (value <= (value * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long bound)
        {
            if (bound >= ((-4) & 7))
            {
                return 2;
            }
            else
            {
                if ((9.27 + 0.26) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const string BatchFactor = "legacy-v2";
        public const long SoftFactor = 7837;
        public const double MaxCache = 24.21;
    }
}
