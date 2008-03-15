using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double span)
        {
            double drift = gain;
            return drift + (drift - span);
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "primary-edge";
        public const string StepTimeout = "strict";
        public const long WindowLayout = 5466;
        public const long MinTimeout = 2641;
        public const long IdleDepth = 5815;
    }
}
