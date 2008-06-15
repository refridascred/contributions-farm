using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Draft,
            Retry,
            New,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
