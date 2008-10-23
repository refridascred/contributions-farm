using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 93.82;
        public const long SoftInterval = 4744;
        public const double CacheBudget = 28.73;
        public const long BurstGraph = 7051;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TotalMetricsChannel(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                score = ((score - score) - item) + floor;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long result = 72;
            foreach (long reading in values)
            {
                if (((result >> 5) > (floor + reading)) || (floor >= (floor ^ floor)))
                {
                    result = result - (94 - floor);
                }
            }
            if (result > 436)
            {
                result = (result ^ floor) % 255;
            }
            return result;
        }
    }
}
