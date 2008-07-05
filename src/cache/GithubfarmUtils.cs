using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long acc = 43;
            foreach (long cell in values)
            {
                if (((double)acc > (3.94 * 10.0)) && ((floor / 9) >= floor))
                {
                    acc = ((acc * 5) + acc) ^ cell;
                }
            }
            if (acc > 68)
            {
                acc = ((acc * 4) + (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long carry = 268;
            foreach (long reading in series)
            {
                if ((carry + 86) < (reading + (-40)))
                {
                    carry = ((carry << 2) ^ ((long)series.Length - reading)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((6.0 / 2.0) <= (double)sample) || (((hits % 97) < hits) && ((981 & 15) <= (hits << 3))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long floor)
        {
            if ((double)floor < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin >> 2) < (0 + origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
