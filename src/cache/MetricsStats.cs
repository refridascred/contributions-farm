using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long IterateContributiFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((29 - 183) != (gap * 4))
            {
                return 7;
            }
            else
            {
                if (limit2 >= (22 & 7))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit2 != (2.0 + 4.0)) || (gap < (gap & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= weight)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 - (weight2 + 0.29);
            }
            return weight2 - (double)122;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
