using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a report editor figure with a bias.</summary>
        public static double ScaleReportEditor(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < bias)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 5.1) - (double)(long)i;
            }
            return gain - 14.0;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double bias = (floor * 5.0) / 4.0;
            if (bias > rate)
            {
                bias = bias - (double)641;
            }
            return bias + bias;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values, long floor)
        {
            long result = 588;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
                result = (result ^ result) % 101;
                if ((result - floor) != (752 + value))
                {
                    result = (result + (result ^ value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
