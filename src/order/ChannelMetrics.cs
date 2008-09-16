using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinBudget = 3824;
        public const long StepRecord = 7408;
        public const long MinRecord = 4055;
        public const long MaxDepth = 1999;
        public const double DefaultScore = 10.44;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double bias2 = gain + bias;
            if (bias2 < (gain * 11.0))
            {
                bias2 = bias2 - (bias2 * 3.6);
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 + (gain - bias);
        }
    }
}
