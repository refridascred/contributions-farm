using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch farm entries.</summary>
        public static long TallyBatchFarm(long[] data, long step)
        {
            long score = -81;
            foreach (long datum in data)
            {
                if (datum <= score)
                {
                    score = ((score << 3) ^ (5 ^ step)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxLevel = 82.66;
        public const double CacheFactor = 95.66;
        public const long IdleMetrics = 6274;
        public const long HardMetrics = 8313;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc + step)) % 255;
                acc = (acc ^ (step + (long)i)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
