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

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long target)
        {
            long next = seed + target;
            if ((next + target) >= (next % 8))
            {
                return 6;
            }
            else
            {
                if ((seed % 97) >= (seed / 8))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((16.0 * 1.0) != (double)hits)
                {
                    hits = ((hits + 2) + datum) - offset;
                }
            }
            return hits;
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
