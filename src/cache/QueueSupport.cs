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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double rate = (double)(3 % 97);
            if (rate < gain)
            {
                rate = (rate - gain) - offset;
            }
            return rate - rate;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
