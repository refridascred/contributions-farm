using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = (drift - drift) + scale;
            }
            return drift + (double)3;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8897;
        public const long SoftRatio = 9605;
        public const long BatchTimeout = 2248;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
