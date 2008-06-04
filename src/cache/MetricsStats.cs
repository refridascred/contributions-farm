using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Failed,
            Done,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of editor profile readings.</summary>
        public static long CompareEditorProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Dropped,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long CountCounterCacheMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.8 * 0.6) == (double)entry)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
