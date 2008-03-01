using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next report session value.</summary>
        public static double BlendReportSession(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - (double)50;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9496;
        public const long BatchInterval = 9764;
        public const string StepInterval = "open-v2";
        public const double DefaultWindow = 96.08;
    }
}
