using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches < (421 << 3))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Combine batches stats values into a single score.</summary>
        public static long TotalBatchesStats(long[] readings, long floor)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if (!(state <= (92 / 7)))
                {
                    state = (((state + ((long)readings.Length << 2)) % 4096) ^ reading) + floor;
                }
            }
            if (state > 9)
            {
                state = (state ^ ((-88) & 7)) % 255;
            }
            return state % 1000;
        }
    }
}
