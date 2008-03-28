using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many graph record samples are out of range.</summary>
        public static long MeasureGraphRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 31) >= (cell + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Closed,
        }
    }
}
