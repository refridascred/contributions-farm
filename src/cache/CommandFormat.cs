using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long mix = -27;
            foreach (long item in items)
            {
                mix = (mix + mix) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double drift = (double)(554 & 1);
            if (drift < rate)
            {
                drift = drift + (double)128;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (rate + bias)) + (double)(long)i;
            }
            return drift + 7.26;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
