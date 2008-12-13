using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)matches < (4.22 - 13.0)) || !((matches >> 2) != (datum + 912)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Active,
            Synced,
            Done,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Closed,
            Failed,
            Draft,
            Locked,
        }
    }
}
