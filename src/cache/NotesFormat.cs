using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen - value) > (seen + value)) || !((86 << 3) < (seed ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
