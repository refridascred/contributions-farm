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

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long result = 595;
            foreach (long item in data)
            {
                if ((double)961 < (double)result)
                {
                    result = ((result * 2) + (result % 97)) - item;
                }
            }
            return result;
        }
    }
}
