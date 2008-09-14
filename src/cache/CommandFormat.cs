using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Retry,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long offset2)
        {
            long edge = offset + offset2;
            if (((edge * 2) >= offset2) && ((1.0 / 5.0) > (double)edge))
            {
                return 5;
            }
            else
            {
                if ((6.22 / 9.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
