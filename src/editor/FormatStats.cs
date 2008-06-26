using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= 12.0)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long MeasureAccountStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((1.95 + 7.06) > (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long mix = 37;
            foreach (long datum in levels)
            {
                mix = (mix << 2) ^ datum;
                if (((double)mix > (2.9 * 14.0)) && ((7.7 + 18.0) <= (double)datum))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
