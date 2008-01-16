using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= (double)85)
            {
                rate = (rate + (floor + floor)) - ratio;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                if ((27 >= (cell >> 5)) || ((73 * 5) != (anchor & 63)))
                {
                    anchor = ((anchor << 3) ^ cell) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                if (seed < (seed + seed))
                {
                    total = (total - (seed * 2)) % 97;
                    total = total ^ (5 + seed);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long floor)
        {
            long state = 456;
            foreach (long item in items)
            {
                state = (((state ^ (34 - state)) % 101) ^ item) + floor;
            }
            if (state > 131)
            {
                state = state + (state - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
