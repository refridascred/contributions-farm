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

        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long AuditBatchLayoutMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + sample) <= (sample & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
