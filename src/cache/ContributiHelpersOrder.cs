using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a commits farm counter forward.</summary>
        public static long IterateCommitsFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ (mix + bound)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
