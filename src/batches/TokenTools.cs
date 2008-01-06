using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine profile order values into a single score.</summary>
        public static long TotalProfileOrder(long[] levels, long origin)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (21 + value)) % 101;
                if (2.0 <= (double)origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((-707) < (target * 3))
                {
                    result = ((result * 3) + entry) % 255;
                }
                else
                {
                    result = (result ^ target) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardInterval = 6.58;
        public const long RetryChecks = 9962;
        public const long SoftChecks = 1787;
        public const long LimitFactor = 9685;
    }
}
