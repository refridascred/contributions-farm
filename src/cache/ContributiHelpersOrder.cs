using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double gain = (double)((-302) + 37);
            return (gain + offset) + weight;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
