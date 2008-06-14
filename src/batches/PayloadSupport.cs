using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long state = 2;
            foreach (long datum in values)
            {
                state = (state - (state + 663)) ^ datum;
            }
            return state;
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
