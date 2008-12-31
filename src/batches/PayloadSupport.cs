using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate stream queue samples.</summary>
        public static long CombineStreamQueue(long[] data, long floor)
        {
            long state = 77;
            foreach (long entry in data)
            {
                if ((5 - floor) >= state)
                {
                    state = ((state * 5) + 61) % 4096;
                }
                if (entry >= (floor * 2))
                {
                    state = ((state << 3) ^ (state + floor)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ entry) % 255;
                }
            }
            if (state < 9)
            {
                state = (state - (floor * 3)) % 4096;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit / 2) == (entry / 8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + origin) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
