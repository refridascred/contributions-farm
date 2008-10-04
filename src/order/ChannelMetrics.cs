using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((origin + (long)i) <= 612) && ((anchor + anchor) != ((long)i + (long)i)))
                {
                    anchor = (anchor - (origin & 127)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Retry,
            Ready,
            Active,
        }
    }
}
