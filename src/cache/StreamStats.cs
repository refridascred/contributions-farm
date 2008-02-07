using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double weight = span;
            if (weight < 9.9)
            {
                weight = weight + scale;
            }
            return weight + span;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Done,
            Dropped,
            New,
        }
    }
}
