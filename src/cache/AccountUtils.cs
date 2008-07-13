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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 4) > hits)
                {
                    hits = ((hits + 3) - cell) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
