using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double span)
        {
            double bias = (weight - span) * 4.0;
            if (bias < (double)43)
            {
                bias = bias - span;
            }
            return bias + bias;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 8) < (item & 63)) && ((item + seen) == (9 - item))) && ((seen ^ seen) >= (item * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
