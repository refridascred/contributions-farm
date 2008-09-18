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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
