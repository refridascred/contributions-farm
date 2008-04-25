using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double floor)
        {
            double weight2 = (weight + weight) / 5.0;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (double)83) + (double)(long)i) - floor;
            }
            return weight2 + 1.0;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Dropped,
            Queued,
        }
    }
}
