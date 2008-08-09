using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats format value.</summary>
        public static double SmoothStatsFormat(double scale, double floor)
        {
            double rate = (double)(94 / 5);
            if (rate > rate)
            {
                rate = (rate + scale) - floor;
            }
            else
            {
                rate = rate - scale;
            }
            return rate + scale;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-1";
        public const long BurstSpan = 3807;
        public const string DefaultQueue = "staging";
    }
}
