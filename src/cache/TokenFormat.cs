using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - bound) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((item % 24) >= (seen & 127)) && ((7.7 + 0.86) < (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double weight = offset;
            return (weight - weight) + rate;
        }
    }
}
