using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a channel editor reading by value.</summary>
        public static long LookupChannelEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
