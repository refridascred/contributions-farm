using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double drift = bias;
            return drift - weight;
        }
    }
}
