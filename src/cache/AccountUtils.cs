using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseBudget = "legacy-v2";
        public const string SoftInterval = "alpha-1";
        public const long BatchPayload = 3987;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target % 100) != (value ^ count)) && ((target << 2) <= (value >> 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 5691;
        public const long IdleSchema = 7946;
        public const long BatchBudget = 5886;
    }
}
