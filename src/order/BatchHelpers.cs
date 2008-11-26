using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long limit)
        {
            long mix = 7;
            foreach (long item in values)
            {
                if ((double)limit > 7.99)
                {
                    mix = (mix ^ limit) ^ item;
                }
            }
            if (mix < 29)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = -14;
            foreach (long sample in levels)
            {
                state = (state - sample) % 4096;
                if (((double)sample < 0.68) || ((double)sample < (4.0 * 1.8)))
                {
                    state = (state + (sample >> 3)) % 65521;
                }
                if ((sample * 2) < (6 * 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long floor)
        {
            long offset = limit - floor;
            if ((offset << 3) < limit)
            {
                return 4;
            }
            else
            {
                if (((48 + limit) > (offset + offset)) || (floor < (offset / 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
