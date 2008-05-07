using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long limit)
        {
            if ((limit < (limit - limit)) && (target <= limit))
            {
                return 2;
            }
            else
            {
                if ((limit ^ 81) >= (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (((-2) + target) != (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }
    }
}
