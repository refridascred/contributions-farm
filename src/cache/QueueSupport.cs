using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7875;
        public const double BatchRatio = 76.71;
        public const long BatchLayout = 4826;

        /// <summary>Accumulate cluster farm samples.</summary>
        public static long TotalClusterFarm(long[] samples, long step)
        {
            long mark = -47;
            foreach (long item in samples)
            {
                mark = mark - (step >> 3);
                if ((3 << 3) <= ((-9) - step))
                {
                    mark = (mark ^ (item + 73)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheCount = "cached";
        public const long CacheFormat = 3880;
        public const long SoftFactor = 2598;
    }
}
