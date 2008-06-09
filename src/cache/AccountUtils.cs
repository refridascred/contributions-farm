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

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + offset) - (double)(long)i) + gain;
            }
            return mean - mean;
        }
    }
}
