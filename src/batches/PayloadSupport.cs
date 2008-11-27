using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((carry ^ target) <= ((long)i & 7)))
                {
                    carry = (carry - (carry - carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of window order readings.</summary>
        public static long TallyWindowOrder(long[] samples, long seed)
        {
            long state = 998;
            foreach (long entry in samples)
            {
                if ((seed * 2) < 9)
                {
                    state = ((state + (state / 6)) % 97) - entry;
                }
                else
                {
                    state = state + (state << 1);
                }
            }
            if (state > (-6))
            {
                state = ((state * 2) + (seed + seed)) % 101;
            }
            return state % 97;
        }
    }
}
