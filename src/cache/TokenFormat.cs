using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings)
        {
            long mark = -82;
            foreach (long cell in readings)
            {
                mark = (mark - (mark >> 2)) % 101;
                if ((63 - mark) == (mark + cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 929;
        public const double CacheCount = 73.35;
        public const long LimitFactor = 9928;
        public const long IdleAlready = 4948;
        public const long StepAlready = 6721;
    }
}
