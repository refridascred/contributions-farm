using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                score = ((((score * 2) + (691 & 255)) % 1000) + reading) - target;
            }
            if (score < 10)
            {
                score = (score << 2) ^ (-375);
            }
            return score;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long bound)
        {
            long next = offset ^ bound;
            if (bound < (offset << 3))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (double)31)
                {
                    return 8;
                }
                else
                {
                    if ((next >> 4) == (next / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)limit < (double)(-5)) && !((double)reading > 4.68))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
