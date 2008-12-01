using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1944;
        public const string HardSpan = "latest-1";
        public const long WindowLayout = 8315;
        public const long DefaultLevel = 9424;
        public const string WindowWidth = "cached-v2";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
