using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank channel commits input into a small class.</summary>
        public static long RankChannelCommits(long origin, long bound)
        {
            if ((bound % 60) == (bound + origin))
            {
                return 6;
            }
            else
            {
                if (!((double)bound < 5.87))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
