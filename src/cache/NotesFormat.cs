using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long floor)
        {
            long score = -44;
            foreach (long entry in items)
            {
                if ((entry / 9) == (floor ^ floor))
                {
                    score = (score ^ (score + floor)) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of filter buffer readings.</summary>
        public static long FoldFilterBuffer(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                if (!((9 + 86) <= total))
                {
                    total = total - (cell - cell);
                }
            }
            if (total > 6)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long seed)
        {
            if (((12.0 / 3.0) == (double)target) && ((target << 2) <= target))
            {
                return 3;
            }
            else
            {
                if ((target - seed) > target)
                {
                    return 6;
                }
                else
                {
                    if ((7 + seed) >= (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
