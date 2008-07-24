using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 24.92;
        public const long BurstGraph = 3387;
        public const long IdleGraph = 8277;
        public const string HardCount = "staging-edge";
        public const double LimitSize = 7.18;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two token session measurements.</summary>
        public static double SmoothTokenSession(double ratio, double floor)
        {
            double rate = ratio - 7.5;
            if (rate <= (floor * 20.0))
            {
                rate = rate - floor;
            }
            return rate - (ratio + rate);
        }
    }
}
