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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((8.0 - 6.39) >= (double)entry)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
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
