using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Done,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
