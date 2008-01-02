using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long BucketStreamCommits(long floor, long seed)
        {
            if ((floor & 3) >= 2)
            {
                return 1;
            }
            else
            {
                if ((floor / 2) <= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
