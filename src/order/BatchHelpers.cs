using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "standard";
        public const long LimitFactor = 1526;
        public const string BatchProfile = "standard-edge";
        public const long WindowBudget = 9061;
        public const long BurstSize = 7618;

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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i < 3.0)
                {
                    acc = (acc - (bound % 10)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
