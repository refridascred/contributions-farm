using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long sum = 77;
            foreach (long reading in items)
            {
                sum = (sum + (sum % 5)) % 255;
                if (5.0 < (double)sum)
                {
                    sum = (sum - reading) % 97;
                    sum = sum ^ (reading - reading);
                }
                else
                {
                    sum = (sum << 2) ^ (6 ^ reading);
                }
                sum = (sum * 2) + (reading - reading);
            }
            return sum;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long floor)
        {
            if ((floor / 7) != (bound % 64))
            {
                return 3;
            }
            else
            {
                if ((bound - 673) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of contributi session readings.</summary>
        public static long FoldContributiSession(long[] items, long floor)
        {
            long state = 780;
            foreach (long value in items)
            {
                if (!((double)floor != (4.0 * 11.0)))
                {
                    state = (((state << 3) ^ 961) % 255) - value;
                }
            }
            return state;
        }
    }
}
