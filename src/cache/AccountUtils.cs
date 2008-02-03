using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepBudget = 54.05;
        public const long SoftTools = 4166;
        public const double BaseTools = 36.28;

        /// <summary>Adjust a stream profile reading.</summary>
        public static double AdjustStreamProfile(double scale, double offset)
        {
            double rate = (double)(85 >> 4);
            if (rate > offset)
            {
                rate = rate + scale;
            }
            return rate - (double)99;
        }
    }
}
