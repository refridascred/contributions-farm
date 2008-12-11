using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long TallyProfileCounterOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(((double)cell > (4.82 - 8.6)) || ((876 - tally) < (tally >> 2))))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                long gap = floor / 5;
                mix = (mix - (mix - (long)i)) % 101;
                if ((((long)i / 9) > floor) || ((gap * 3) >= (gap >> 1)))
                {
                    mix = (mix - (long)i) % 255;
                    gap = (gap ^ (15 & 255)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long ScoreSchemaAlready(long[] readings, long target)
        {
            long state = 21;
            foreach (long value in readings)
            {
                if ((0.49 / 7.0) == (double)state)
                {
                    state = (((state << 3) ^ (state + 613)) % 1000) - target;
                }
                state = state ^ (value * 5);
            }
            return state;
        }
    }
}
