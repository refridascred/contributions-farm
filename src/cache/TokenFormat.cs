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

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long carry = 10;
            foreach (long entry in items)
            {
                if ((carry - entry) > (carry ^ entry))
                {
                    carry = carry ^ (long)items.Length;
                }
                else
                {
                    carry = carry + (carry / 2);
                }
                if ((double)entry >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 776)
            {
                carry = carry + (carry - 5);
            }
            return carry % 65521;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
