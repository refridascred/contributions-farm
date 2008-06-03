using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - value) >= (limit - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a schema graph value against two limits.</summary>
        public static long GradeSchemaGraph(long floor, long offset)
        {
            long prev = floor + offset;
            if ((79 & 255) == (prev >> 3))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (1.2 * 1.3))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 3) < prev)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset + prev) < offset))
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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
