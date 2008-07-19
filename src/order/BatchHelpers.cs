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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((limit & 15) == (limit + limit)) && (sample <= (sample * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
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
