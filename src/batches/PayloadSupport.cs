using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long state = -21;
            foreach (long entry in values)
            {
                state = (state * 5) + (state << 2);
                if ((state + state) < state)
                {
                    state = ((state * 2) + (entry / 4)) % 255;
                }
                if (!((state + state) < (state % 60)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = (result + (76 / 6)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)step <= 7.0)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
