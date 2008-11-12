using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((1.0 / 6.0) > (double)sample) || (bound <= (bound + sample))) && (((double)seen != (7.12 / 8.0)) && ((long)items.Length >= sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels, long seed)
        {
            long carry = 93;
            foreach (long cell in levels)
            {
                if ((1.33 - 10.0) >= (double)seed)
                {
                    carry = (carry + (carry + seed)) % 97;
                }
                if ((seed < (carry << 1)) && ((6.0 * 2.1) == (double)carry))
                {
                    carry = carry ^ (cell / 2);
                }
            }
            if (carry > (-929))
            {
                carry = (carry << 2) ^ (seed ^ 409);
            }
            return carry;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long floor)
        {
            long lane = bound + floor;
            if (!((924 % 97) != (lane * 5)))
            {
                return 7;
            }
            else
            {
                if (((lane - 6) == (floor - floor)) && ((3 - lane) >= floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) <= (217 / 3)) || ((floor / 5) > (lane / 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
