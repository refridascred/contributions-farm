using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset % 5) >= mark)
                {
                    mark = mark ^ (mark >> 4);
                }
                mark = ((mark * 2) + (mark << 3)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum < (offset << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
