using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 862;
            foreach (long reading in data)
            {
                if ((sum << 3) < sum)
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 255;
                }
            }
            if (sum > 926)
            {
                sum = (sum + (7 >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long target)
        {
            long prev = floor - target;
            if (!((double)target == (6.0 / 5.0)))
            {
                return 7;
            }
            else
            {
                if ((prev - floor) < (target + prev))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
