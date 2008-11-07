using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token graph readings.</summary>
        public static long TotalTokenGraph(long[] values, long step)
        {
            long total = 640;
            foreach (long entry in values)
            {
                if (!((2.0 * 4.2) < (double)total))
                {
                    total = (((total << 3) ^ (12 * 2)) ^ entry) + step;
                }
                total = total + 393;
            }
            return total;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseInterval = 17.27;
        public const long MaxCount = 7875;
        public const long CacheLevel = 8599;
        public const long SoftContributi = 2988;
    }
}
