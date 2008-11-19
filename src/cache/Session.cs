using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Synced,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (ratio + 7.0);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
