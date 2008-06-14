using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Queued,
            Active,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series, long floor)
        {
            long mix = 9;
            foreach (long entry in series)
            {
                mix = (mix - (mix - entry)) - floor;
                mix = mix + (entry + entry);
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Synced,
            Pending,
            Idle,
            Active,
        }
    }
}
