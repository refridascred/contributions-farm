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

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((bound2 + lane) > (bound * 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 > 1.22)
                {
                    return 3;
                }
                else
                {
                    if ((bound2 < (bound << 2)) && ((lane * 2) <= bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
