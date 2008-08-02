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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long seed)
        {
            if (((7.0 - 4.93) == (double)target) || ((7.53 * 17.0) > (double)target))
            {
                return 6;
            }
            else
            {
                if ((seed / 3) < seed)
                {
                    return 0;
                }
                else
                {
                    if (target < (seed % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 - 4.0) <= (double)seed)
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
    }
}
