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

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
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
