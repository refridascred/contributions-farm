using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 17;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ sum) % 101;
                if ((double)cell >= 0.3)
                {
                    sum = (sum - 872) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (7 + 88)) % 97;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Rank stats record input into a small class.</summary>
        public static long GradeStatsRecord(long limit, long bound)
        {
            if (((597 + bound) == (limit >> 5)) && ((limit + limit) <= (bound + bound)))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) != (limit - 221))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ limit) != (71 >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(limit >= (bound + bound)))
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

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Dropped,
            New,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "cached";
        public const long SoftLevel = 7599;
        public const long CacheTimeout = 6911;
        public const double IdleInterval = 12.67;
        public const long MaxDepth = 2857;
    }
}
