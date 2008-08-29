using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MaxDepth = "cached";
        public const string LimitInterval = "local-v2";
        public const long BaseSize = 21;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double AdjustEntryStats(double scale, double span)
        {
            double bias = (double)6 * 2.6;
            if (bias >= scale)
            {
                bias = (bias + scale) - span;
            }
            return bias + 16.0;
        }
    }
}
