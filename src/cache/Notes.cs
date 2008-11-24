using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
