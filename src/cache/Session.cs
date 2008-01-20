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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
