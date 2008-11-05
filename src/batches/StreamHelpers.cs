using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((target & 63) <= (target ^ 86))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long LookupRouteChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 6763;
        public const double HardBudget = 75.39;
        public const long DefaultMetric = 6196;
        public const long LimitRatio = 2479;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long MeasureSchemaRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 4) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
