using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            long bound = origin - target;
            if (((target ^ (-5)) > (origin / 9)) && ((bound >> 3) > (origin * 2)))
            {
                return 0;
            }
            else
            {
                if (!((8.77 + 15.0) != (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session channel readings against a rule.</summary>
        public static long TallySessionChannelHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((42 >= offset) && ((entry % 2) <= (offset + entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((72 & 15) > (cell ^ count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
