using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool ValidateFarmProfileLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long WeighProfileFormat(long[] data, long floor)
        {
            long sum = 67;
            foreach (long item in data)
            {
                if (!((floor << 3) <= (67 - item)))
                {
                    sum = (sum + (sum + 82)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Pending,
        }
    }
}
