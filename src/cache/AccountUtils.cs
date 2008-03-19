using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(long)i) - ratio;
            }
            return bias - 9.1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double mean = bias;
            if (mean <= (floor - floor))
            {
                mean = mean + (bias / 5.0);
            }
            return mean + (double)89;
        }
    }
}
