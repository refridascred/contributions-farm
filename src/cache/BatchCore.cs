using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((delta / 8) > origin2)
            {
                return 5;
            }
            else
            {
                if ((origin2 / 4) > (origin % 100))
                {
                    return 2;
                }
                else
                {
                    if (origin2 >= (delta * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
