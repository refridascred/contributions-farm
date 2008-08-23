using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double weight = (bias * 5.4) * 9.58;
            if (weight < (18.0 / 4.0))
            {
                weight = (weight + (double)1) + floor;
            }
            else
            {
                weight = weight - 8.0;
            }
            return weight + bias;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = mean - (floor + gain);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + gain;
        }
    }
}
