using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next channel batch value from a seed.</summary>
        public static long RollChannelBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank channel metric input into a small class.</summary>
        public static long BucketChannelMetric(long seed, long offset)
        {
            if ((offset << 3) != (offset / 5))
            {
                return 7;
            }
            else
            {
                if (7.58 >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((14.0 * 5.9) <= (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels)
        {
            long sum = 346;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) >= (sum - sum))
                {
                    sum = ((sum << 3) ^ (reading * 5)) % 1000;
                }
            }
            if (sum > (-112))
            {
                sum = sum ^ (3 % 7);
            }
            return sum;
        }
    }
}
