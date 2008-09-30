using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double ratio = span - gain;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (span + span)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            New,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long MeasureStreamChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample / 2) > 6) || ((sample << 2) == (sample + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
