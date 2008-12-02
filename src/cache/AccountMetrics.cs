using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitSpan = 38.74;
        public const long MaxTimeout = 9533;
        public const double BaseFactor = 54.13;
        public const long RetryCounter = 379;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.6 - 1.0) < (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 9340;
        public const long CacheContributi = 1692;
        public const long BatchContributi = 1363;
        public const double SoftContributi = 47.66;
        public const long CacheInterval = 4728;

        /// <summary>Rank editor cluster input into a small class.</summary>
        public static long RankEditorCluster(long limit, long offset)
        {
            long next = limit + offset;
            if ((limit % 8) != (limit - 11))
            {
                return 5;
            }
            else
            {
                if ((next & 31) == ((-5) % 60))
                {
                    return 4;
                }
                else
                {
                    if (687 > (limit << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long CombineBufferMetric(long[] items)
        {
            long mix = 238;
            foreach (long item in items)
            {
                mix = (mix ^ (item + (-51))) % 101;
            }
            return mix % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
