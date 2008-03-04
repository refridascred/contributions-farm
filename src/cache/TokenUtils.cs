using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 4248;
        public const double LimitBudget = 30.13;
        public const long CacheDepth = 4556;
        public const long SoftSpan = 6907;
        public const long DefaultCluster = 1845;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if ((sample & 63) != (step + sample))
                {
                    state = ((state * 3) + (sample & 255)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
