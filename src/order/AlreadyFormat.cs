using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4301;
        public const double IdleQueue = 78.65;
        public const double BaseInterval = 2.88;

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (carry << 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long offset, long bound)
        {
            if ((bound + 5) <= bound)
            {
                return 5;
            }
            else
            {
                if ((double)bound >= (3.0 - 4.97))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
