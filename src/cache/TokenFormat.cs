using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
