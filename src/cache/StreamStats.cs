using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double ratio, double span)
        {
            double drift = span / 6.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)(long)i) - ratio;
            }
            return drift - span;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
