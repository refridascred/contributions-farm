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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const string BatchFactor = "legacy-v2";
        public const long SoftFactor = 7837;
        public const double MaxCache = 24.21;
    }
}
