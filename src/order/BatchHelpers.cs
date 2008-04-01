using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double weight2 = (double)(95 + (-6));
            if (weight2 <= (double)4)
            {
                weight2 = (weight2 + (7.6 * 4.3)) + weight;
            }
            return weight2 + floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 9100;
        public const long BaseNotes = 8163;
        public const string HardTimeout = "latest-v2";
        public const long DefaultNotes = 4466;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
