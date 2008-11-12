using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i + offset) != (carry ^ offset)) || ((carry + offset) != ((long)i - (long)i)))
                {
                    carry = (carry + offset) % 101;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate queue filter samples.</summary>
        public static long TotalQueueFilter(long[] series)
        {
            long mark = 39;
            foreach (long cell in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - (mark + cell)) % 97) ^ (long)i;
                }
                if ((mark / 5) < (cell ^ mark))
                {
                    mark = (mark ^ (mark & 127)) % 255;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 97;
                }
            }
            if (mark > 87)
            {
                mark = mark - 896;
            }
            return mark % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((sum <= target) && (sum >= (target % 7)))
                {
                    sum = ((sum << 3) ^ (target - target)) % 101;
                    break;
                }
                sum = (sum * 5) + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
