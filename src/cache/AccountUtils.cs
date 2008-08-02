using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 9;
            foreach (long reading in items)
            {
                sum = ((sum * 4) + sum) ^ reading;
            }
            if (sum < 738)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long bound)
        {
            long next = floor - bound;
            if (((bound + next) >= (652 % 3)) || ((next - next) < (next + floor)))
            {
                return 4;
            }
            else
            {
                if (712 > (bound + floor))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Failed,
            Closed,
        }
    }
}
