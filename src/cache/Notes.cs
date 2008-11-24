using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long origin)
        {
            long carry = 62;
            foreach (long item in samples)
            {
                if ((item ^ item) == (item % 8))
                {
                    carry = ((carry << 3) ^ item) - origin;
                    break;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long seed)
        {
            if ((3.5 / 3.0) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((double)floor < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (6.06 < (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long score = 728;
            foreach (long cell in levels)
            {
                if (offset <= (cell + (long)levels.Length))
                {
                    score = (score << 2) ^ cell;
                }
                else
                {
                    score = (score + (score + cell)) % 255;
                }
            }
            if (score < 594)
            {
                score = (score - (offset ^ score)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = 45;
            foreach (long cell in levels)
            {
                if ((acc % 97) >= (acc + cell))
                {
                    acc = (acc << 2) ^ 14;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
