using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double rate2 = (double)(70 - 616);
            return ((rate2 + rate2) + rate) + span;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
