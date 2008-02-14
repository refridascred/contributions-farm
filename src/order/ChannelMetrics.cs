using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "legacy-v2";
        public const long MinBatch = 9412;
        public const double DefaultBatch = 81.8;
        public const double HardBatch = 19.87;
        public const double MinWidth = 41.29;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mark = 937;
            foreach (long sample in items)
            {
                mark = ((mark - 861) % 255) - sample;
                if (mark < (origin / 8))
                {
                    mark = (mark ^ 83) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
