using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next filter account value.</summary>
        public static double SmoothFilterAccount(double ratio, double span)
        {
            double weight = (ratio + span) / 8.0;
            if (weight < ratio)
            {
                weight = weight - (ratio + weight);
            }
            return weight + (ratio * 6.0);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
