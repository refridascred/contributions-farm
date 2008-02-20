using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long offset)
        {
            long mix = 348;
            foreach (long cell in values)
            {
                if (((cell >> 5) == (cell - offset)) || ((3.2 * 1.93) <= (double)cell))
                {
                    mix = mix + (cell >> 5);
                    mix = mix + (offset << 3);
                }
                mix = (mix + (685 >> 5)) % 4096;
                if (((offset + offset) < (cell << 1)) && ((double)offset > 2.86))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
