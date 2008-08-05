using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double rate = 15.0;
            if (rate <= rate)
            {
                rate = (rate - (floor + rate)) + weight;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + floor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
