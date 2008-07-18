using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next notes cache value from a seed.</summary>
        public static long SeriesNotesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((1 > (limit % 10)) || ((carry << 3) <= (limit + carry)))
                {
                    carry = ((carry * 5) + (17 + (long)i)) % 255;
                    carry = ((carry << 2) ^ carry) % 101;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
