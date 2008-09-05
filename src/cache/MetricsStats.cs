using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] samples)
        {
            long result = 220;
            foreach (long cell in samples)
            {
                if ((419 / 3) < cell)
                {
                    result = ((result << 2) ^ (6 >> 3)) % 101;
                }
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long bound, long step)
        {
            if (5.75 < (double)step)
            {
                return 8;
            }
            else
            {
                if (94 > (bound - step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((double)seen > 5.0))
                {
                    seen = ((seen + 1) + reading) - target;
                }
            }
            return seen;
        }
    }
}
