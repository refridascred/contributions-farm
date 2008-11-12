using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Accumulate token command samples.</summary>
        public static long DigestTokenCommand(long[] values)
        {
            long acc = 52;
            foreach (long entry in values)
            {
                if (!((acc - entry) == (20 + entry)))
                {
                    acc = acc - (acc * 2);
                }
            }
            return acc;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Stale,
        }
    }
}
