using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen * 5) > (seen >> 4))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((floor - 39) == (1 / 4))
            {
                return 5;
            }
            else
            {
                if ((0.5 + 5.6) != (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
