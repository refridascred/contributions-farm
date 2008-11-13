using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double weight = span;
            if (weight < ratio)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (weight - 3.67);
            }
            return weight + span;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
