using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Queued,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Measure how many schema metric samples are out of range.</summary>
        public static long MeasureSchemaMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value << 1) > (value / 9)) || ((value & 127) <= value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double bias = span;
            if (bias < span)
            {
                bias = bias + (bias + rate);
            }
            else
            {
                bias = bias - (span * 5.5);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }
    }
}
