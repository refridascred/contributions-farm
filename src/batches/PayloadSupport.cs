using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double bias2)
        {
            double weight = (double)79 - (bias * 6.9);
            if (weight < weight)
            {
                weight = (weight - (15.0 * 7.0)) - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (4.7 * 8.9)) + (double)(long)i;
            }
            return weight - (bias * 5.83);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double floor)
        {
            double weight = 4.9 - (bias / 3.0);
            if (weight < (floor + bias))
            {
                weight = weight - (bias * 7.91);
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (floor * 7.8);
        }
    }
}
