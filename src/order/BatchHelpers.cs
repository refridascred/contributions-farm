using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count batches format pairs that satisfy a relation.</summary>
        public static long CompareBatchesFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long seed)
        {
            long score = 92;
            foreach (long item in series)
            {
                if ((score - item) <= item)
                {
                    score = (score << 2) ^ (score ^ 849);
                }
                else
                {
                    score = (score * 4) + (item + seed);
                }
            }
            if (score > 47)
            {
                score = (score ^ (score ^ score)) % 97;
            }
            return score;
        }
    }
}
