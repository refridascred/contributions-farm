using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool GuardSupportFilterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
