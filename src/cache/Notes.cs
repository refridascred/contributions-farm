using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 15) >= ((long)readings.Length + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long floor)
        {
            if ((floor * 5) <= (floor >> 1))
            {
                return 7;
            }
            else
            {
                if ((double)199 == (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 2654;
        public const long HardFarm = 7079;
        public const string LimitDepth = "stable-v2";
        public const long LimitFarm = 4411;
        public const long StepBudget = 7502;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
