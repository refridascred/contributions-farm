using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)9) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Stale,
            Draft,
            New,
        }
    }
}
