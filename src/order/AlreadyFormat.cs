using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long bound)
        {
            long slot = seed + bound;
            if ((slot / 5) <= (bound - seed))
            {
                return 2;
            }
            else
            {
                if ((seed & 127) <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ bound) < (bound % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
