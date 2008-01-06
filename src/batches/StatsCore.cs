using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long total = 139;
            foreach (long sample in items)
            {
                if (!((total - sample) < (756 >> 5)))
                {
                    total = (((total * 4) + (sample % 60)) % 4096) - offset;
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 81.73;
        public const double BurstRecord = 75.1;
        public const long IdleCount = 209;
        public const long MinRecord = 7882;
        public const long BatchRecord = 7290;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5.0 + 8.81) != (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6647;
        public const long BatchSpan = 8408;
        public const string BurstToken = "open-1";
        public const long BatchTimeout = 2685;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + hits) <= item)
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
