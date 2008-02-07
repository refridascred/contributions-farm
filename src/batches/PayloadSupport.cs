using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Dropped,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
