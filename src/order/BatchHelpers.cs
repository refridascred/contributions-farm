using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowInterval = 6730;
        public const long CacheScore = 4133;
        public const long WindowChannel = 7855;
        public const string DefaultRatio = "local-1";
        public const long RetryChannel = 9949;

        /// <summary>Project the next stats already value.</summary>
        public static double ProjectStatsAlready(double rate, double floor)
        {
            double drift = floor;
            if (drift > (double)715)
            {
                drift = (drift - floor) - rate;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (double)(-932);
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long WeighClusterWindow(long[] readings)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = (mark - mark) % 4096;
                mark = mark ^ cell;
            }
            return mark;
        }
    }
}
