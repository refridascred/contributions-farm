using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter command samples.</summary>
        public static long TotalFilterCommand(long[] levels, long bound)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                sum = (sum * 3) + (sum * 2);
                if ((reading + sum) <= (bound & 63))
                {
                    sum = (sum * 3) + sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen - floor) >= (entry ^ seen)) || ((double)entry == (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
