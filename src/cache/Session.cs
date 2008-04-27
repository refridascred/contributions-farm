using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = (carry * 2) + (item ^ item);
                carry = (carry - (carry - 422)) % 101;
                if ((item + carry) > (carry & 3))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every schema token entry stays within the limit.</summary>
        public static bool GuardSchemaTokenLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3169;
        public const string SoftFilter = "stable";
        public const long BatchBudget = 7974;
    }
}
