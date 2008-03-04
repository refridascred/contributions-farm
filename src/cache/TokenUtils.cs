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

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long total = 68;
            foreach (long entry in data)
            {
                if ((double)entry < 4.81)
                {
                    total = (((total << 2) ^ (total - (-884))) % 97) + offset;
                }
            }
            return total % 1000;
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
