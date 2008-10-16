using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long bound)
        {
            long mix = 824;
            foreach (long entry in values)
            {
                if (bound >= (entry - 98))
                {
                    mix = (mix << 2) ^ (entry % 64);
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values)
        {
            long carry = 70;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (carry ^ cell)) % 1000;
                if ((cell >> 3) != ((long)values.Length >> 4))
                {
                    carry = ((carry << 2) ^ cell) % 1000;
                }
            }
            if (carry < 471)
            {
                carry = carry + (56 % 60);
            }
            return carry;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
