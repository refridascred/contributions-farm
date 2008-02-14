using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long offset)
        {
            long prev = target ^ offset;
            if (((offset - prev) >= (target >> 2)) || ((4.0 - 12.0) > (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) == (4 - value))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + target) <= (50 + target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
