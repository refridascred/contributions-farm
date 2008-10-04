using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 86.05;
        public const double IdleLevel = 70.11;
        public const long BaseBatch = 5755;
        public const long MinSpan = 9957;
        public const long LimitScore = 8522;

        /// <summary>Project the next graph channel value.</summary>
        public static double ScaleGraphChannel(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (8.68 * 8.62))
            {
                bias2 = bias2 - (double)43;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
