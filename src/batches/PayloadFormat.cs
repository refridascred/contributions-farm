using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((matches * 2) == (datum + 965)) && ((datum + matches) <= matches)) && ((double)871 > (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
