using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((62 + offset) > (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)644 >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!(78 < (offset ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBudget = 61.75;
        public const long MaxLevel = 5694;
        public const long CacheBatch = 1272;
    }
}
