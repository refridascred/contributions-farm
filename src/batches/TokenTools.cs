using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a entry stats reading.</summary>
        public static double BlendEntryStats(double weight, double span)
        {
            double mean = span;
            if (mean >= (double)19)
            {
                mean = (mean + (15.0 + span)) + weight;
            }
            return mean - mean;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
