using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Done,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 4) + (606 + anchor);
                anchor = ((anchor << 3) ^ (limit - 441)) % 4096;
                if (!((long)i <= (limit - 166)))
                {
                    anchor = anchor - 1;
                    anchor = (anchor + 70) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
