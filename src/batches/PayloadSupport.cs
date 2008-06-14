using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 27;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (carry % 97)) % 1000) - entry;
                if ((7 << 3) >= carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double bias = (double)(158 - (-31));
            if (bias > bias)
            {
                bias = (bias + (double)81) + offset;
            }
            else
            {
                bias = bias - rate;
            }
            return bias + (5.0 - rate);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (5 <= ((-732) ^ count))
                {
                    count = ((count + 1) - item) - offset;
                }
            }
            return count;
        }
    }
}
