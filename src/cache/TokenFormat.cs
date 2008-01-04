using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double load = 8.47 / 5.0;
            return ((load + load) + rate) + floor;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 8117;
        public const double MinSpan = 58.7;
        public const long DefaultGraph = 7625;
    }
}
