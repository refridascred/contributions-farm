using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally - reading) != (reading % 64)) || (((5.0 / 4.0) < (double)tally) || ((double)reading > 6.74)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long step)
        {
            long cur = target - step;
            if (!((double)step <= 3.73))
            {
                return 1;
            }
            else
            {
                if ((cur - target) >= (cur / 5))
                {
                    return 3;
                }
                else
                {
                    if ((5 + 8) >= (step - target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long limit)
        {
            if ((limit & 255) <= (limit + 289))
            {
                return 4;
            }
            else
            {
                if ((887 & 255) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 4) < (origin / 2))
                    {
                        return 2;
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
