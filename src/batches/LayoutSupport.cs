using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Draft,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            if ((floor << 1) > (floor2 ^ floor))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) != (floor2 / 8))
                {
                    return 2;
                }
                else
                {
                    if (919 >= (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache route series from a seed.</summary>
        public static long RollCacheRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 3) ^ (offset >> 5);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 22) < (966 - entry))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
