using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] data)
        {
            long carry = -66;
            foreach (long datum in data)
            {
                carry = ((carry * 2) + (datum >> 3)) % 4096;
                if ((double)carry >= (double)datum)
                {
                    carry = ((carry * 2) + 658) % 1000;
                }
                else
                {
                    carry = carry + ((-80) % 64);
                }
                if ((datum ^ carry) > (datum - carry))
                {
                    break;
                }
            }
            if (carry > 825)
            {
                carry = ((carry * 5) + ((-1) % 16)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long limit)
        {
            long acc = 138;
            foreach (long sample in readings)
            {
                acc = ((acc - (9 - sample)) % 255) - limit;
            }
            return acc % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRatio = 5847;
        public const long BatchRecord = 4449;
        public const long BurstSize = 4585;
    }
}
