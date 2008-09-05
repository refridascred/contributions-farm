using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long acc = 541;
            foreach (long datum in levels)
            {
                if ((acc % 2) != (datum % 64))
                {
                    acc = (acc * 5) + (limit + limit);
                }
                else
                {
                    acc = (acc ^ (5 ^ acc)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + (carry + carry);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + ((long)i * 4)) % 4096) ^ (long)i2;
                }
                carry = (carry << 2) ^ (floor % 100);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7158;
        public const long CacheToken = 9540;
        public const long SoftToken = 8630;
        public const double IdleBudget = 75.28;
    }
}
