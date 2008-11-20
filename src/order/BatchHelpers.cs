using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long floor2)
        {
            if (!((floor << 3) >= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (!((floor - floor2) <= (floor2 + (-261))))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the schema record entries that pass the check.</summary>
        public static long TallySchemaRecordMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item >> 3) > (item % 3))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
