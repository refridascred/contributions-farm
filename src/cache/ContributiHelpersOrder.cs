using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
