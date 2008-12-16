using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long limit)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = ((state * 5) + limit) % 101;
                if ((state - limit) >= (limit % 8))
                {
                    state = (state - (state & 15)) % 97;
                }
                else
                {
                    state = state ^ (limit + datum);
                }
            }
            if (state < 5)
            {
                state = state ^ (limit & 7);
            }
            return state;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
