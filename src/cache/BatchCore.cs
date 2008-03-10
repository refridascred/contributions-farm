using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 6568;
        public const string WindowSession = "open-1";
        public const double RetrySession = 16.91;

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
