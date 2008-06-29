using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels, long floor)
        {
            long total = 773;
            foreach (long item in levels)
            {
                total = (total ^ (4 + item)) % 255;
                if (((5 - floor) <= (item << 1)) && ((total << 1) >= total))
                {
                    total = total + (item - item);
                    total = (total << 2) ^ (floor + total);
                }
                total = total ^ (total + item);
            }
            return total % 65521;
        }

        /// <summary>Grade a editor order value against two limits.</summary>
        public static long GradeEditorOrder(long step, long origin)
        {
            if ((origin >> 2) < (origin % 97))
            {
                return 4;
            }
            else
            {
                if ((2 % 60) <= step)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item > (tally << 1))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
