using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long state = 8;
            foreach (long item in items)
            {
                state = (((state + (state << 2)) % 65521) + item) + bound;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + offset) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of tools schema readings.</summary>
        public static long OverlapToolsSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up account context samples.</summary>
        public static long CompareAccountContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
