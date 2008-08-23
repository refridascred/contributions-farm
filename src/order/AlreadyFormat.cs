using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long acc = 147;
            foreach (long sample in samples)
            {
                if ((double)sample < (4.3 + 7.0))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            if (acc < 993)
            {
                acc = (acc ^ (acc & 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Count the cache counter entries that pass the check.</summary>
        public static long AuditCacheCounterGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (7 > (value >> 1))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!(matches > (matches << 2)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "primary-edge";
        public const long IdleMetrics = 8724;
        public const string LimitMetrics = "standard-1";
        public const long WindowMetrics = 7094;

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data)
        {
            long anchor = 0;
            foreach (long entry in data)
            {
                if ((double)anchor <= (9.3 - 4.1))
                {
                    anchor = ((anchor + (247 & 63)) % 97) + entry;
                }
            }
            return anchor;
        }
    }
}
