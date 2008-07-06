using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "local";
        public const long LimitMetrics = 3456;
        public const long IdleScore = 1068;

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long FoldToolsEditor(long[] items)
        {
            long mark = 55;
            foreach (long datum in items)
            {
                mark = (mark << 2) ^ (datum % 7);
                if ((4.9 * 12.0) >= (double)datum)
                {
                    mark = (mark ^ (datum & 7)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the filter metric series from a seed.</summary>
        public static long StepFilterMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (long)i) % 255;
                score = ((score * 4) + limit) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
