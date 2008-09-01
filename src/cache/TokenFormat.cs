using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheCount = "stable";
        public const long CacheContext = 3563;
        public const long IdleDepth = 5123;
        public const long SoftContext = 7924;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mark > (6.46 / 8.0))
                {
                    mark = ((mark * 2) + ((long)i & 31)) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ floor;
                    mark = (mark * 5) + floor;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
