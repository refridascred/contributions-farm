using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long origin)
        {
            long state = 87;
            foreach (long cell in readings)
            {
                if (12.0 < (double)cell)
                {
                    state = (state - ((long)readings.Length + (long)readings.Length)) % 1000;
                }
            }
            if (state > 82)
            {
                state = (state + origin) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Locked,
            Pending,
        }
    }
}
