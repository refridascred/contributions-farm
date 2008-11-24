using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route support pair into a bucket.</summary>
        public static long SortRouteSupport(long limit, long origin)
        {
            if ((double)limit > (6.7 - 3.8))
            {
                return 8;
            }
            else
            {
                if (3.48 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (8.3 * 7.24)) + (double)(long)i) - gain;
            }
            return rate + (rate * 15.0);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double bias = (double)(300 + (-52));
            if (bias > 9.3)
            {
                bias = bias - (offset + 5.0);
            }
            else
            {
                bias = bias + (offset * 9.81);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - rate)) + (double)(long)i;
            }
            return bias + (double)0;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
