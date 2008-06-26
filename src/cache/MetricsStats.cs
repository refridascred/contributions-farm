using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 29.42;
        public const string CacheRatio = "open";
        public const long SoftBatches = 5580;
        public const string MinBatches = "stable-v2";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel layout pairs that satisfy a relation.</summary>
        public static long PairChannelLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits << 1) != (hits + cell)) && !(((-257) + 405) != (cell >> 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
