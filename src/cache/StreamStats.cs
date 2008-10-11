using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 1;
            foreach (long cell in values)
            {
                result = (result - cell) % 101;
                if (((double)cell > (14.0 - 18.0)) || ((1.0 + 20.0) < (double)result))
                {
                    result = (result << 2) ^ (result + cell);
                }
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits <= (6.6 + 7.27))
                {
                    hits = ((hits + 1) + sample) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate account already readings against a bound.</summary>
        public static bool ValidateAccountAlreadyLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches == (double)datum)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
