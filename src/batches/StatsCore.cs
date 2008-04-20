using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleSpan = 67.25;
        public const double SoftContributi = 70.45;
        public const long BaseContributi = 1476;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((604 < (count - count)) || ((double)count <= (2.0 / 5.0)))
                {
                    count = ((count + 3) + entry) + offset;
                }
            }
            return count;
        }
    }
}
