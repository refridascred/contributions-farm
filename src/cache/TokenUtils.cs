using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long floor)
        {
            if (floor <= (limit + limit))
            {
                return 2;
            }
            else
            {
                if (((double)limit >= 11.0) && ((floor + floor) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit + floor) == (floor % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings, long seed)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = (sum + seed) - sample;
            }
            if (sum > (-8))
            {
                sum = (sum * 4) + (sum & 1);
            }
            return sum;
        }
    }
}
