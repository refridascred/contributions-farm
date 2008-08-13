using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batches route samples.</summary>
        public static long FoldBatchesRoute(long[] series, long seed)
        {
            long mark = 5;
            foreach (long item in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark + (long)i) % 101;
                }
                if (!(item > (0 + 2)))
                {
                    mark = mark + (seed + mark);
                }
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)state <= (13.0 * 2.0))
                {
                    state = state + (state + floor);
                }
                else
                {
                    state = state ^ (floor & 1);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
