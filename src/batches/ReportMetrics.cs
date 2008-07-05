using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 59.27;
        public const long IdleBuffer = 5601;
        public const double CacheBuffer = 95.73;
        public const long RetryBuffer = 2168;
        public const long IdleScore = 8011;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i >> 1) > (total * 5))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                else
                {
                    total = total - (origin ^ (long)i);
                    total = ((total << 2) ^ (origin * 5)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((93 - value) < (seed << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
