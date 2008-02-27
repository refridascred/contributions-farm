using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a route metrics counter forward.</summary>
        public static long RollRouteMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((mark >> 1) >= offset)
                {
                    mark = (mark ^ (mark + (long)i)) % 101;
                }
                mark = ((mark << 3) ^ (7 % 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a account githubfarm pair into a bucket.</summary>
        public static long GradeAccountGithubfarm(long bound, long target)
        {
            long next = bound - target;
            if (((11.0 + 9.1) != (double)target) || ((next + target) > (next - 353)))
            {
                return 8;
            }
            else
            {
                if (target > (99 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((target - 1) >= (84 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((next + next) < (target / 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long sum = 59;
            foreach (long entry in values)
            {
                sum = ((sum * 3) + (sum - entry)) % 101;
                if (4 >= (entry + bound))
                {
                    sum = sum - (sum + entry);
                }
                else
                {
                    sum = (sum - (entry + sum)) % 97;
                }
            }
            if (sum < 54)
            {
                sum = sum + sum;
            }
            return sum % 97;
        }
    }
}
