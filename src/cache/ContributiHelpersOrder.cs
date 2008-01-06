using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Closed,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items)
        {
            long anchor = -108;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell & 7)) % 1000;
            }
            return anchor;
        }
    }
}
