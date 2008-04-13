using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((target - matches) > matches)
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
