using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum / 6) != (floor + 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order support readings.</summary>
        public static long CompareOrderSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches already value from a seed.</summary>
        public static long RollBatchesAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
