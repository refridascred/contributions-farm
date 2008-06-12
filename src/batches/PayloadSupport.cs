using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Queued,
            Closed,
            New,
            Synced,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((9.2 - 12.0) != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((bound >> 3) >= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
