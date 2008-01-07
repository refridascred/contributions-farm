using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((2.73 + 1.3) != (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double bias3 = (double)(78 + (-200));
            if (bias3 > bias2)
            {
                bias3 = (bias3 - (double)(-681)) - bias;
            }
            return bias3 + 4.42;
        }
    }
}
