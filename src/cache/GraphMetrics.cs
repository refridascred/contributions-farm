using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 8449;
        public const double MinFactor = 2.17;
        public const long LimitCount = 594;
        public const string BaseDepth = "cached-1";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen ^ seed) >= (8 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Draft,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 196;
        public const string MaxLevel = "legacy-edge";
        public const long BurstSize = 8017;
        public const long IdleTimeout = 1660;
        public const long BaseCommand = 157;
    }
}
