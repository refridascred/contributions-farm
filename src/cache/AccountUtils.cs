using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TotalStreamQueue(long[] levels, long floor)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                result = (result - floor) + cell;
            }
            if (result > 681)
            {
                result = result + (floor + result);
            }
            return result % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            if (((seed - floor) < (floor + floor)) && ((double)floor != (double)seed))
            {
                return 2;
            }
            else
            {
                if (((seed + floor) >= (seed & 15)) || ((5.0 - 14.0) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if ((bound << 3) < (entry + bound))
                {
                    total = total - total;
                }
            }
            if (total < (-9))
            {
                total = ((total << 3) ^ (bound - bound)) % 65521;
            }
            return total;
        }
    }
}
