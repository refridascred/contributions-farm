using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long seed)
        {
            if (!((3.0 * 2.4) < (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin + 90) != (seed + origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 34.01;
        public const double RetryLevel = 94.34;
        public const string CacheSize = "staging-1";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 3) > hits)
                {
                    hits = ((hits + 2) - datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + (mix ^ 2);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
