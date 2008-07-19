using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] values, long bound)
        {
            long sum = 96;
            foreach (long datum in values)
            {
                if ((double)bound <= (9.29 + 9.9))
                {
                    sum = (sum + (datum << 1)) % 65521;
                }
                else
                {
                    sum = sum ^ (bound % 64);
                }
            }
            if (sum > 75)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long seed)
        {
            long next = target + seed;
            if (target > 450)
            {
                return 4;
            }
            else
            {
                if ((target + 567) <= (target - next))
                {
                    return 7;
                }
                else
                {
                    if ((next + next) == (target - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
