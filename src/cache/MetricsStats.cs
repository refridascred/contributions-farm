using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (623 + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank metrics layout input into a small class.</summary>
        public static long GradeMetricsLayout(long step, long limit)
        {
            long edge = step + limit;
            if ((double)limit != (8.6 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((0 << 1) > (edge - limit))
                {
                    return 4;
                }
                else
                {
                    if (!(limit > (2 + edge)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally >= 8.0)
                {
                    tally = ((tally + 1) + entry) + limit;
                }
            }
            return tally;
        }
    }
}
