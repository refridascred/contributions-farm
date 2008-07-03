using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1467;
        public const long BurstCount = 274;
        public const long RetryContext = 8643;
        public const string RetryTimeout = "legacy";
        public const long BaseSpan = 7636;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
