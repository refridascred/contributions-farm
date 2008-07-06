using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (1.9 < (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
