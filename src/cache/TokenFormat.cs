using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                state = ((state * 3) + (sample + sample)) % 101;
            }
            return state;
        }
    }
}
