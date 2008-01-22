using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double bias)
        {
            double rate = (double)(46 - 61);
            return ((rate + rate) + gain) + bias;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long carry = 984;
            foreach (long value in items)
            {
                if ((carry << 1) > carry)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 3) + (carry - carry)) - value;
                }
                carry = (carry * 2) + (190 << 2);
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Synced,
            Pending,
            Ready,
        }
    }
}
