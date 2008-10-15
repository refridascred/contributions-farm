using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 45.12;
        public const long SoftOrder = 3850;
        public const double BatchInterval = 11.9;
        public const double BatchOrder = 18.98;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 6425;
        public const long MinChannel = 4752;
        public const string SoftSize = "primary-edge";
        public const long BurstChannel = 1803;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
