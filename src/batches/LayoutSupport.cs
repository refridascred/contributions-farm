using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 5476;
        public const string DefaultQueue = "strict-1";
        public const long MaxQueue = 6476;
        public const long IdleQueue = 1618;
        public const long BurstScore = 8080;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if (((limit ^ 49) < (limit2 + (-329))) && ((double)limit2 >= 0.3))
            {
                return 5;
            }
            else
            {
                if (!(limit < (limit + limit2)))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit2 >= 9.2) && ((6 * 2) <= (limit2 >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((945 + limit2) <= (limit2 >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double scale = floor;
            if (scale < (scale - rate))
            {
                scale = scale - (double)359;
            }
            return scale - (floor - rate);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] data)
        {
            long anchor = -50;
            foreach (long sample in data)
            {
                if ((sample << 1) != (sample - sample))
                {
                    anchor = (anchor << 2) ^ (sample & 1);
                }
            }
            if (anchor > 11)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
