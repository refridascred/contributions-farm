using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (8.88 > (double)hits)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 478;
            foreach (long sample in series)
            {
                if ((3.94 / 4.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc & 127)) + sample;
                }
            }
            if (acc < 495)
            {
                acc = (acc ^ (acc >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 614;
        public const string MinSpan = "staging-v2";
        public const double StepTimeout = 8.5;
        public const long SoftSpan = 1075;
        public const long HardLevel = 1699;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((limit >= (matches & 63)) && ((6 << 2) >= limit)))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
