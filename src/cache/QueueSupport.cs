using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double scale = (double)(-67) - (bias / 4.0);
            if (scale > bias)
            {
                scale = (scale - (scale / 2.0)) - bias2;
            }
            return scale - 19.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5771;
        public const long WindowFactor = 945;
        public const long BatchLevel = 9717;
        public const string WindowBudget = "strict";
    }
}
