using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultBudget = 3.57;
        public const long MaxSchema = 6689;
        public const long LimitSchema = 6788;
        public const long RetrySchema = 7602;
        public const long BatchRatio = 7858;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchFactor = 654;
        public const string WindowCount = "standard-edge";
        public const long WindowSpan = 1416;
        public const string WindowLevel = "alpha-1";
    }
}
