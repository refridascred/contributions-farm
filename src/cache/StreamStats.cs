using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches > (9.5 / 2.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Queued,
            Draft,
            Locked,
            New,
        }
    }
}
