using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Stale,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next counter order value from a seed.</summary>
        public static long DeriveCounterOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
