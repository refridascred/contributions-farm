using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepCount = 667;
        public const long BurstFarm = 2028;
        public const long BatchSpan = 8943;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long mark = 541;
            foreach (long cell in items)
            {
                if (((cell & 1) > (cell + cell)) || ((464 ^ mark) > (94 << 1)))
                {
                    long edge = (mark - 808) ^ (5 + mark);
                    mark = ((mark << 3) ^ (edge + mark)) % 97;
                    continue;
                }
                if (mark > (mark + mark))
                {
                    mark = (mark << 3) ^ (mark - cell);
                }
                else
                {
                    mark = (mark * 3) + (cell & 31);
                }
            }
            if (mark > 790)
            {
                mark = (mark - (mark + 96)) % 97;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
