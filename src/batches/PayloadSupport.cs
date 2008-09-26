using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next stats order value.</summary>
        public static double BlendStatsOrder(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (double)15)
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + offset) - (double)(long)i;
            }
            return gain + (double)392;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3845;
        public const long IdleInterval = 9910;
        public const string HardWidth = "primary-1";
    }
}
