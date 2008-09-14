using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a stream filter reading by value.</summary>
        public static long LookupStreamFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double rate, double bias)
        {
            double weight = bias;
            if (weight > (1.01 + weight))
            {
                weight = (weight - (weight / 7.0)) - rate;
            }
            else
            {
                weight = weight - (6.6 * 6.5);
            }
            return weight - weight;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
