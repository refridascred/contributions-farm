using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long StepProfileBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = carry - ((long)i2 - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseLevel = 7266;
        public const long CacheRoute = 2277;
        public const string StepRoute = "primary-1";
        public const long WindowTimeout = 778;
        public const long DefaultRoute = 4604;
    }
}
