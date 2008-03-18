using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a profile metric pair into a bucket.</summary>
        public static long RankProfileMetric(long seed, long step)
        {
            long slot = seed + step;
            if ((3.9 / 5.0) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((seed ^ step) <= (slot + slot)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)slot == (13.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 3) == (slot * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Synced,
            Failed,
            Ready,
            Retry,
        }
    }
}
