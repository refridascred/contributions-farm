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

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3248;
        public const long BaseInterval = 6015;
        public const long RetryInterval = 178;

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
