using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate schema editor samples.</summary>
        public static long DigestSchemaEditor(long[] readings)
        {
            long state = 360;
            foreach (long value in readings)
            {
                if ((state + value) >= (state & 15))
                {
                    state = state + (value / 8);
                }
                else
                {
                    state = (state - value) % 101;
                }
            }
            if (state > 8)
            {
                state = (state - state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Locked,
            New,
            Pending,
            Retry,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double gain = bias;
            return (gain - bias) + rate;
        }
    }
}
