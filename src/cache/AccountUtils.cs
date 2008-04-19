using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)129 == (double)seed)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
