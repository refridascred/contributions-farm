using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate commits cluster samples.</summary>
        public static long TallyCommitsCluster(long[] samples)
        {
            long mark = 493;
            foreach (long reading in samples)
            {
                long lane = (33 + reading) + (6 & 31);
                mark = mark ^ (mark + lane);
                mark = mark ^ (reading ^ reading);
            }
            if (mark > 9)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinInterval = "legacy-edge";
        public const double DefaultCounter = 48.39;
        public const long LimitWidth = 7975;

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long SortQueueEntry(long floor, long floor2)
        {
            if (((double)floor != (6.9 * 6.26)) && ((double)floor2 <= 2.0))
            {
                return 2;
            }
            else
            {
                if ((double)78 == (double)floor2)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
