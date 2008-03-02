using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double weight = (4.2 + offset) - (scale / 6.0);
            if (weight <= (weight * 6.1))
            {
                weight = weight - 15.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (scale / 2.0)) + (double)(long)i;
            }
            return weight - (8.0 / 5.0);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double bias = (double)(54 / 3);
            if (bias >= (bias * 7.3))
            {
                bias = (bias - 3.4) - span;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (bias * 8.0);
        }
    }
}
