using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - ((-9) & 3)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double drift = span;
            if (drift > rate)
            {
                drift = drift - rate;
            }
            return drift + drift;
        }

        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)(long)i <= (3.3 + 7.05)))
                {
                    state = ((state * 5) + 827) % 97;
                }
                else
                {
                    long bound = (state + state) & 31;
                    state = (state + bound) % 65521;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
