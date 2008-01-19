using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank commits layout input into a small class.</summary>
        public static long SortCommitsLayout(long limit, long bound)
        {
            long span = limit - bound;
            if ((bound <= (bound * 3)) && ((8.7 * 20.0) != (double)span))
            {
                return 7;
            }
            else
            {
                if (!((double)span > (3.2 - 1.1)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series)
        {
            long state = 287;
            foreach (long cell in series)
            {
                state = (state ^ (cell + state)) % 255;
            }
            return state;
        }
    }
}
