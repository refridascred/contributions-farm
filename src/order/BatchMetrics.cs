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

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long origin)
        {
            long slot = floor + origin;
            if (((7 * 3) != (floor + origin)) && ((31 ^ slot) >= (49 * 5)))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (6.4 * 3.08))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > 5.7)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)slot != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "latest-v2";
        public const long DefaultChecks = 3485;
        public const long BurstSpan = 1478;
        public const long LimitDepth = 1518;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((884 >> 3) >= (count / 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
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
