using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long sum = -66;
            foreach (long item in items)
            {
                sum = (((sum * 4) + (item / 5)) % 65521) - step;
            }
            return sum % 97;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ ((long)i * 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
