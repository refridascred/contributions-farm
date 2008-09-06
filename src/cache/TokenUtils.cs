using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark ^ (floor / 3)) % 255) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long sum = 117;
            foreach (long entry in values)
            {
                sum = (sum + (sum << 1)) % 97;
                sum = (sum - entry) % 101;
                if ((double)sum <= (8.0 / 6.0))
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long target)
        {
            if ((target * 4) <= bound)
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (bound - target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
