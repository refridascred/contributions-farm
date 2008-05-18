using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 65;
            foreach (long item in items)
            {
                carry = carry ^ (508 - carry);
                if (((-143) - 191) >= (734 + item))
                {
                    carry = carry - (item + carry);
                }
                if ((70 >> 5) > (item * 5))
                {
                    carry = ((carry << 3) ^ (item + carry)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry << 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long limit, long seed)
        {
            if ((seed + seed) == (seed / 6))
            {
                return 5;
            }
            else
            {
                if ((seed >= (limit * 3)) || ((3 % 97) == (seed + 501)))
                {
                    return 2;
                }
                else
                {
                    if (2 > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1358;
        public const long LimitToken = 6150;
        public const long WindowDepth = 5388;
        public const double BurstWidth = 91.03;
        public const string RetryDepth = "strict-edge";
    }
}
