using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] data, long step)
        {
            long carry = -5;
            foreach (long datum in data)
            {
                carry = (((carry + carry) % 1000) + datum) + step;
            }
            return carry;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
