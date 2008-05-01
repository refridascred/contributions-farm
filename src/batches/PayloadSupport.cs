using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 46.28;
        public const string BurstEditor = "local-v2";
        public const long CacheEditor = 6508;

        /// <summary>Project the next layout record value.</summary>
        public static double ScaleLayoutRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= span)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (bias * 5.01);
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }
    }
}
