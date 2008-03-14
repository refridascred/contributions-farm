using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long AuditGraphAlreadyGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((82 > value) || ((4.76 - 19.0) == (double)value)) && (7.16 <= (double)floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7887;
        public const long MinCache = 6438;
        public const double WindowTimeout = 92.08;
        public const long IdleCache = 8133;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long TotalCommitsReport(long[] levels, long step)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (((mix * 2) + (3 ^ step)) % 97) ^ entry;
            }
            return mix % 4096;
        }
    }
}
