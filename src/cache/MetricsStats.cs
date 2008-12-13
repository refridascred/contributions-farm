using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((9.06 * 11.0) == (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double weight = ratio + (ratio - 20.0);
            if (weight > 12.0)
            {
                weight = (weight - (weight * 1.9)) + bias;
            }
            else
            {
                weight = weight - 6.54;
            }
            return weight + 7.7;
        }
    }
}
