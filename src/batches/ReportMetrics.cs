using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Retry,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(6.08 > (double)matches) || ((-71) < (288 - matches)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
