using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches << 2) != (floor % 60))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Idle,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long RankCacheMetrics(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((diff * 4) <= 6)
            {
                return 5;
            }
            else
            {
                if ((diff - diff) == (97 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)diff == (15.0 / 4.0)) || ((offset - diff) <= diff))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
