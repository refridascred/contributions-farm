using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long floor)
        {
            long score = 836;
            foreach (long cell in levels)
            {
                score = ((score ^ (cell - score)) % 255) - floor;
            }
            return score;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double ratio = bias / 5.0;
            if (ratio >= (weight + 2.49))
            {
                ratio = ratio - (bias - 2.4);
            }
            return ratio - ratio;
        }
    }
}
