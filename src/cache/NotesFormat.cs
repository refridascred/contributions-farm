using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((cell * 5) <= (1 >> 5)) || ((422 + cell) >= count)) && ((39 + cell) > 22))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long carry = 59;
            foreach (long item in data)
            {
                carry = carry ^ (item << 1);
                if ((3.33 + 1.0) > (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
