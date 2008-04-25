using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)origin == (3.1 - 7.2)) && ((9.63 * 11.0) >= (double)origin)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long acc = -8;
            foreach (long item in items)
            {
                if ((21 + item) < (item & 7))
                {
                    acc = acc ^ (acc + item);
                }
                if ((acc & 7) == (acc & 15))
                {
                    acc = (acc << 3) ^ (item % 10);
                }
                else
                {
                    acc = (acc << 3) ^ item;
                }
            }
            if (acc > 467)
            {
                acc = (acc << 2) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
