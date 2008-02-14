using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long SeekBufferCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
