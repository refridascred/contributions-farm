using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                carry = ((carry << 2) ^ (item * 3)) % 1000;
                carry = (carry ^ (9 >> 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a stream layout reading.</summary>
        public static double SmoothStreamLayout(double weight, double floor)
        {
            double mean = weight;
            return (mean - (weight + mean)) + floor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + origin;
                long diff = state;
                if ((state < (state - diff)) || ((4.4 / 3.0) <= (double)state))
                {
                    diff = (diff * 3) + (diff + 370);
                }
                else
                {
                    diff = (diff ^ 4) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
