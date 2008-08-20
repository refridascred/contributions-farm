using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (item >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
