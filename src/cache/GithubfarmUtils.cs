using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5428;
        public const long MaxScore = 683;
        public const double IdleWidth = 76.38;

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (bound % 3)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry * 3) + (bound + 7)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels)
        {
            long sum = 82;
            foreach (long cell in levels)
            {
                double ratio = (double)(cell * 3);
                if ((double)sum >= ratio)
                {
                    ratio = ratio - (double)sum;
                    sum = (sum + (sum >> 2)) % 101;
                    break;
                }
                if ((-630) > (cell - 5))
                {
                    sum = ((sum << 2) ^ (128 << 3)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
            }
            if (sum > (-14))
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }
    }
}
