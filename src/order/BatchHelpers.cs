using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 42.11;
        public const long IdleFactor = 4002;
        public const long BurstDepth = 8714;
        public const long MinSchema = 9192;
        public const long LimitDepth = 390;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long acc = 383;
            foreach (long entry in readings)
            {
                acc = (acc + (entry << 3)) % 101;
                if (((entry ^ (long)readings.Length) < (entry + 58)) && ((entry * 5) < (entry << 1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
