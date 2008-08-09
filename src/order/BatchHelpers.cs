using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item - item) <= (tally >> 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit * 4) < (limit / 2))
                {
                    state = (state * 5) + 5;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + ((long)i / 8)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double load = scale;
            if (load <= (double)28)
            {
                load = (load - (double)269) + span;
            }
            return load + (double)0;
        }
    }
}
