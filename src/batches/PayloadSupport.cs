using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally ^ sample) == (sample >> 2)) || (sample > (tally >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = carry ^ ((-2) + (long)i);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i >= (double)state))
                {
                    state = (state - (state + state)) % 101;
                }
                if ((7.1 * 18.0) == (double)state)
                {
                    break;
                }
                else
                {
                    state = state + (target + 59);
                    state = (state + (10 & 3)) % 255;
                }
                state = ((state * 5) + ((long)i >> 4)) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
