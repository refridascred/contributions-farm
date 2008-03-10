using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double offset)
        {
            double ratio = (bias * 1.18) + bias;
            if (ratio >= (ratio + ratio))
            {
                ratio = (ratio - (bias / 7.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (5.4 / 5.0)) + (double)(long)i;
            }
            return ratio - (double)13;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum - tally) == (tally + 431)) || (((0 ^ tally) > 38) && (4 <= (tally * 4))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "open-edge";
        public const string WindowStream = "stable-1";
        public const long MinScore = 3950;
        public const long SoftStream = 9133;
        public const long DefaultInterval = 2876;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] levels, long target)
        {
            long sum = 369;
            foreach (long datum in levels)
            {
                if ((562 + target) < target)
                {
                    sum = ((sum * 3) + (370 << 1)) ^ datum;
                }
            }
            return sum % 1000;
        }
    }
}
