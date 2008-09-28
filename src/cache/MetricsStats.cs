using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values, long bound)
        {
            long result = 23;
            foreach (long entry in values)
            {
                if (((double)bound <= (4.0 * 9.0)) || (3.0 < (double)bound))
                {
                    result = result - (entry + 965);
                }
                else
                {
                    result = (result - (result + entry)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((target % 24) >= 9)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Closed,
            Dropped,
            Synced,
            Ready,
        }
    }
}
