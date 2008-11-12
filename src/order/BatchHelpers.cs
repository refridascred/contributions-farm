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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long offset2)
        {
            if ((double)offset2 >= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((offset + offset) == (offset2 - offset2))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset2 != (8.41 * 1.5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 / 6) != (offset * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
