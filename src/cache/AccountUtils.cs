using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double mean = 8.0 - (bias / 2.0);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - bias) + (double)(long)i) + floor;
            }
            return mean - (double)18;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4129;
        public const string BatchDepth = "legacy-1";
        public const long IdleFactor = 3567;
        public const long WindowReport = 6513;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
