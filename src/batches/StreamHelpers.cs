using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if (limit2 >= 358)
            {
                return 7;
            }
            else
            {
                if ((94 - limit) > (limit & 255))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 << 1) < (43 - 643))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLevel = 70.39;
        public const double BatchLayout = 92.64;
        public const long CacheInterval = 4511;
        public const double MaxBudget = 39.82;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
