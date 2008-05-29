using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first support account entry that matches the target.</summary>
        public static long LocateSupportAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long step)
        {
            long acc = 495;
            foreach (long sample in levels)
            {
                if ((double)acc <= (8.7 - 8.0))
                {
                    acc = (acc + sample) % 1000;
                    acc = acc + (step & 3);
                }
                else
                {
                    acc = (acc + acc) % 101;
                }
                if (167 < (acc >> 2))
                {
                    acc = (acc - step) % 101;
                }
                else
                {
                    acc = acc - 50;
                }
            }
            if (acc < (-4))
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a entry command sample.</summary>
        public static long LocateEntryCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
