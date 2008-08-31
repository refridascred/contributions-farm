using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long ScoreAccountGraph(long[] data)
        {
            long mix = 76;
            foreach (long value in data)
            {
                mix = (mix ^ (19 << 1)) ^ value;
            }
            return mix;
        }
    }
}
