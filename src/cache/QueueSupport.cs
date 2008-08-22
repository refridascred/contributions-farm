using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long ClassifyMetricsFarm(long origin, long limit)
        {
            if (origin > (limit << 1))
            {
                return 2;
            }
            else
            {
                if (0.3 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (origin < (limit + 94))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
