using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double gain = bias;
            if (gain < (bias + span))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = -81;
            foreach (long entry in values)
            {
                carry = (carry * 3) + (entry + carry);
                carry = carry - (976 * 5);
            }
            if (carry < 369)
            {
                carry = (carry - (22 - (long)values.Length)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter tools sample.</summary>
        public static long LocateCounterToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
