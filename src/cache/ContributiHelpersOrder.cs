using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Failed,
            New,
            Locked,
            Stale,
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
