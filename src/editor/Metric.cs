using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many booking samples are out of range.</summary>
        public static long CountBookingGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches % 2) <= ((-44) % 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
