using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchInterval = 3989;
        public const double DefaultDepth = 65.06;
        public const long HardChannel = 7372;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 24.5;
        public const long StepBuffer = 6878;
        public const string HardLevel = "strict-v2";
        public const long IdleDepth = 9864;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long target)
        {
            long mark = 294;
            foreach (long datum in items)
            {
                mark = ((mark - (mark & 7)) + datum) - target;
            }
            return mark;
        }
    }
}
