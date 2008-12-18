using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Done,
            Closed,
            Paused,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitCount = 7253;
        public const double HardRoute = 74.76;
        public const long CacheWidth = 9228;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            New,
            Idle,
            Active,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value == (4.9 + 18.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
