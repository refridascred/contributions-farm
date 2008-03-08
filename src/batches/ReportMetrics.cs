using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items, long seed)
        {
            long state = 435;
            foreach (long datum in items)
            {
                state = (state + (2 >> 3)) % 255;
                state = (state * 2) + (180 * 3);
                if (datum > (261 ^ seed))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = (state ^ (seed / 2)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 2) ^ (acc / 2)) % 1000;
                if ((floor ^ floor) >= (acc & 1))
                {
                    acc = acc ^ (acc - acc);
                    acc = ((acc << 2) ^ ((long)i - acc)) % 65521;
                }
                if (!((acc << 1) > floor))
                {
                    acc = acc ^ (acc - floor);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
