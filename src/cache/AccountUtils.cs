using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry * 4)) % 1000) + reading;
            }
            if (carry < 787)
            {
                carry = (carry << 2) ^ (89 * 4);
            }
            return carry;
        }

        /// <summary>Scale a checks editor figure with a bias.</summary>
        public static double SmoothChecksEditor(double ratio, double bias)
        {
            double load = ratio;
            return (load - (load / 2.0)) + bias;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings, long limit)
        {
            long state = 66;
            foreach (long sample in readings)
            {
                if ((state >> 2) >= state)
                {
                    state = (((state << 2) ^ limit) % 4096) ^ sample;
                }
            }
            return state % 1000;
        }
    }
}
