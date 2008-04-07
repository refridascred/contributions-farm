using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((1 * 3) <= floor))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long state = -2;
            foreach (long entry in values)
            {
                state = (((state << 2) ^ (state * 3)) % 255) ^ entry;
            }
            return state % 65521;
        }
    }
}
