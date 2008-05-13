using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = -36;
            foreach (long reading in data)
            {
                if ((score & 7) <= (reading + score))
                {
                    score = ((score << 2) ^ (score / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstCount = 59.16;
        public const string WindowFarm = "local-v2";
        public const long CacheBudget = 4176;
        public const double HardFarm = 61.39;
        public const string DefaultSpan = "standard-1";

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
