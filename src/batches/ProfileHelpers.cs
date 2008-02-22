using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstScore = 12.27;
        public const double LimitFilter = 47.28;
        public const long CacheFilter = 6059;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long WeighToolsAccount(long[] levels)
        {
            long acc = -8;
            foreach (long value in levels)
            {
                if ((239 & 31) < (176 + value))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
                if ((2 & 1) != (value - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels, long offset)
        {
            long state = -9;
            foreach (long datum in levels)
            {
                state = ((((state * 4) + (state - state)) % 255) - datum) - offset;
            }
            return state % 97;
        }
    }
}
