using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 1396;
        public const long LimitStats = 3549;
        public const long LimitWidth = 2376;
        public const long MaxSpan = 3405;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + ((long)i + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
