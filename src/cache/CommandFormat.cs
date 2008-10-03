using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a payload editor figure with a bias.</summary>
        public static double AdjustPayloadEditor(double rate, double span)
        {
            double weight = (rate / 3.0) - span;
            if (weight > (rate + span))
            {
                weight = weight + (weight + weight);
            }
            return weight - span;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= (double)611)
            {
                bias2 = (bias2 - (double)441) + bias;
            }
            return bias2 + (offset * 6.6);
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Stale,
            Synced,
            Ready,
        }
    }
}
