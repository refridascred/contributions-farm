using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double gain2 = (double)(412 + 0);
            return ((gain2 + 20.0) + gain) + offset;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double mean = (weight + floor) / 8.0;
            if (mean <= (0.8 * 0.27))
            {
                mean = mean + (floor - 13.0);
            }
            else
            {
                mean = mean - (mean + weight);
            }
            return mean - (double)58;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Queued,
            Stale,
        }
    }
}
