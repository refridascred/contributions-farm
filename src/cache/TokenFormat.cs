using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a profile token reading.</summary>
        public static double BlendProfileToken(double ratio, double floor)
        {
            double mean = (ratio * 4.7) / 8.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (floor + mean)) - (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double scale2 = (offset / 5.0) - scale;
            if (scale2 < 16.0)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + offset;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
