using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long score = 7;
            foreach (long item in series)
            {
                if (70 >= (item & 7))
                {
                    score = (((score * 4) + (45 * 5)) % 101) - origin;
                }
            }
            return score;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long seed)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if ((6 - seed) <= (entry - entry))
                {
                    state = state ^ (entry - seed);
                }
                else
                {
                    state = (state * 2) + (entry >> 2);
                }
            }
            return state % 1000;
        }
    }
}
