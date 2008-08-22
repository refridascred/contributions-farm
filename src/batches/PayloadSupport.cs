using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long limit)
        {
            long next = seed - limit;
            if ((limit + next) == (seed - limit))
            {
                return 6;
            }
            else
            {
                if (!((limit / 3) < (next + 6)))
                {
                    return 8;
                }
                else
                {
                    if ((1.6 + 1.9) < (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 10) > limit) || (next > 467))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
