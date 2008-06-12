using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Combine editor cache values into a single score.</summary>
        public static long CombineEditorCache(long[] values, long origin)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (origin + entry)) % 65521;
            }
            return state % 65521;
        }
    }
}
