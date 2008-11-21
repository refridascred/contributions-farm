using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a schema token value against two limits.</summary>
        public static long SortSchemaToken(long target, long target2)
        {
            if (((target2 << 2) > target) && ((target2 >> 3) > (target - target2)))
            {
                return 4;
            }
            else
            {
                if ((6 - target2) < (target & 63))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value ^ tally) <= (value + step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "latest-v2";
        public const long DefaultChecks = 3485;
        public const long BurstSpan = 1478;
        public const long LimitDepth = 1518;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item > (0.9 * 15.0))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
