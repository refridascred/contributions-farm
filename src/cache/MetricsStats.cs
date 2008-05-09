using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a batches profile counter forward.</summary>
        public static long DeriveBatchesProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftTimeout = 4930;
        public const long MaxScore = 4434;
        public const long LimitContributi = 2908;
        public const long DefaultContributi = 3503;
        public const long MinScore = 6403;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((origin - cell) <= (origin % 97)) && ((449 - hits) == (20 / 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
