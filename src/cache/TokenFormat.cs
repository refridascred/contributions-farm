using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two metrics profile measurements.</summary>
        public static double AdjustMetricsProfile(double scale, double span)
        {
            double ratio = span * 0.4;
            if (ratio <= (double)2)
            {
                ratio = (ratio - span) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)9;
        }
    }
}
