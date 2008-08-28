using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double weight = (double)(629 - 864);
            if (weight >= (ratio - 18.0))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + 8.87;
            }
            return weight - ratio;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
