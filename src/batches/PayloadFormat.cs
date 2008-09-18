using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double span)
        {
            double bias2 = (double)(258 % 3);
            if (bias2 <= bias)
            {
                bias2 = (bias2 - 0.07) + span;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 * 4.37);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long floor)
        {
            long carry = 27;
            foreach (long item in samples)
            {
                if (((3.3 * 2.96) <= (double)carry) && ((item ^ floor) >= (630 / 5)))
                {
                    carry = carry ^ (2 + item);
                }
            }
            if (carry < 1)
            {
                carry = (carry - (13 - carry)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ tally) == (tally >> 5))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
