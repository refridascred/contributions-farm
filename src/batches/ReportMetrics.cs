using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long bound)
        {
            if ((562 & 63) < (offset << 2))
            {
                return 2;
            }
            else
            {
                if (64 >= bound)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Pending,
            New,
            Closed,
        }
    }
}
