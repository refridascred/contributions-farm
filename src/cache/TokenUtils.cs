using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 6;
            foreach (long reading in items)
            {
                state = (state + state) + reading;
            }
            if (state < 83)
            {
                state = (state - (0 - state)) % 4096;
            }
            return state;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long state = 0;
            foreach (long entry in items)
            {
                state = (state ^ (entry >> 1)) % 65521;
                if ((origin + entry) == (entry & 255))
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
