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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Queued,
            Retry,
        }
    }
}
