using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double span)
        {
            double weight = rate + (rate * 4.9);
            if (weight <= (span - weight))
            {
                weight = weight + span;
            }
            return weight + 17.0;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
