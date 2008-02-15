using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two command queue measurements.</summary>
        public static double ProjectCommandQueue(double scale, double span)
        {
            double scale2 = (4.8 / 6.0) / 3.0;
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale) - span;
            }
            else
            {
                scale2 = scale2 - (6.2 * 6.6);
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double weight = 5.4;
            return (weight + span) + gain;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
