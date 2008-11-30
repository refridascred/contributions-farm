using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long offset)
        {
            long state = 988;
            foreach (long reading in levels)
            {
                state = (state ^ (reading - offset)) % 97;
            }
            if (state < 9)
            {
                state = ((state * 5) + ((-2) - offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((548 % 60) < (origin & 31))
                {
                    state = (state + state) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long bound, long offset)
        {
            if ((5.73 * 1.93) > (double)bound)
            {
                return 3;
            }
            else
            {
                if (93 <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
