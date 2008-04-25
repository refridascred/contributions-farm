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

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long MeasureStreamSupportGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= 8.9)
                {
                    matches = ((matches + 3) - item) - origin;
                }
            }
            return matches;
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
