using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Ready,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long limit)
        {
            long mix = 452;
            foreach (long sample in data)
            {
                mix = ((mix - ((-35) ^ mix)) - sample) - limit;
                if ((mix - mix) != (mix & 31))
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Paused,
            Ready,
            Idle,
        }
    }
}
