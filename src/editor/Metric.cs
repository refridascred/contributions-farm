using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double bias2 = (double)4 / 2.0;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 - (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 + (double)741;
        }
    }
}
