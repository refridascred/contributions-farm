using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "standard";
        public const double WindowBudget = 98.08;
        public const double RetrySpan = 2.54;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
