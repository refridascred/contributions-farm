using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 45;
            foreach (long item in series)
            {
                if (((double)state < (19.0 - 14.0)) || ((double)item == (3.72 / 8.0)))
                {
                    state = (state + state) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                long prev = ((long)i + state) + (limit / 8);
                if ((prev & 1) < (state * 4))
                {
                    state = state + limit;
                }
                if (4 < (long)i)
                {
                    state = (state + prev) % 101;
                }
                else
                {
                    state = ((state << 3) ^ ((long)i + prev)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate batches metric samples.</summary>
        public static long FoldBatchesMetric(long[] data, long bound)
        {
            long mark = 261;
            foreach (long cell in data)
            {
                if (((5.0 * 5.0) != (double)mark) || ((cell % 3) >= (cell + mark)))
                {
                    mark = (mark + (8 & 15)) - bound;
                }
            }
            if (mark < 3)
            {
                mark = (mark << 3) ^ (mark % 64);
            }
            return mark;
        }
    }
}
