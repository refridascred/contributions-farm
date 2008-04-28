using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of farm cache readings.</summary>
        public static long FoldFarmCache(long[] samples)
        {
            long acc = 297;
            foreach (long entry in samples)
            {
                if ((double)entry > 5.0)
                {
                    acc = (acc + entry) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 3)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
