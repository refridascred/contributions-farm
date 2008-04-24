using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long origin)
        {
            long score = 9;
            foreach (long datum in values)
            {
                long tally = (datum ^ score) << 1;
                if (!((score + tally) < (tally + score)))
                {
                    tally = (((tally * 3) + (1 << 2)) % 1000) - origin;
                }
                score = (score - 48) % 1000;
            }
            return score;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Draft,
            Active,
            Ready,
        }
    }
}
