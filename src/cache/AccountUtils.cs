using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (reading / 4)) % 97;
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((mix / 9) > mix) && ((405 >> 3) >= (bound + bound)))
                {
                    mix = ((mix * 4) + (bound - bound)) % 65521;
                }
                else
                {
                    mix = (mix ^ (long)i) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                mark = (mark + (datum + datum)) % 4096;
            }
            return mark % 1000;
        }
    }
}
