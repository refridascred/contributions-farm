using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long offset)
        {
            long mark = 880;
            foreach (long sample in data)
            {
                if ((910 + 67) >= mark)
                {
                    mark = ((mark ^ mark) % 255) ^ sample;
                }
                if ((7.2 - 1.0) == (double)offset)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
