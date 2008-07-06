using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
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
