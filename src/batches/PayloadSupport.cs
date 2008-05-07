using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double weight = (double)(522 << 1);
            if (weight <= (scale / 7.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (double)15;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (bias * 0.3);
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseWidth = 7416;
        public const long BaseCache = 4570;
        public const long HardRatio = 5824;
        public const long LimitBudget = 9754;
    }
}
