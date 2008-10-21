using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ (floor & 31)) % 255;
                state = (state - state) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((2.8 / 9.0) > (double)reading)
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
