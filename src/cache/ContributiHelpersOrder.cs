using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items, long target)
        {
            long anchor = 239;
            foreach (long sample in items)
            {
                anchor = ((((anchor << 2) ^ (68 + 9)) % 65521) - sample) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Dropped,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
