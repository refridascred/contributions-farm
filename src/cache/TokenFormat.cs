using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 5) != (value << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long floor)
        {
            if ((700 / 7) > limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit > 0.2)
                {
                    return 6;
                }
                else
                {
                    if ((floor < (limit * 4)) && ((737 & 7) <= (limit >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit ^ floor) == (limit * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryScore = 55.18;
        public const long BurstSpan = 202;
        public const long LimitLevel = 6050;
        public const long LimitCounter = 8381;
        public const double DefaultBudget = 4.81;
    }
}
