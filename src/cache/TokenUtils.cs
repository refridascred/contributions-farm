using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((bound - origin) != (bound + origin))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) < (origin << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound == (7.75 / 6.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long sum = 232;
            foreach (long cell in levels)
            {
                if (!((sum - cell) < (sum & 3)))
                {
                    sum = sum ^ (floor / 3);
                }
            }
            if (sum > 248)
            {
                sum = ((sum << 2) ^ (floor ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (203 * 3)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
