using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stats cluster entries.</summary>
        public static long CombineStatsCluster(long[] readings)
        {
            long mark = 17;
            foreach (long cell in readings)
            {
                if (!((double)cell >= (4.0 * 2.09)))
                {
                    mark = mark ^ (cell & 255);
                }
            }
            if (mark > 8)
            {
                mark = (mark * 5) + (mark / 7);
            }
            return mark;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long anchor = 77;
            foreach (long item in samples)
            {
                if ((item >> 5) <= (item + 46))
                {
                    anchor = ((anchor ^ item) % 65521) - target;
                }
                else
                {
                    anchor = (anchor + (anchor / 7)) % 255;
                }
            }
            if (anchor > (-9))
            {
                anchor = anchor + (anchor + 97);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstInterval = "open-1";
        public const double StepWidth = 93.17;
        public const long WindowFactor = 8907;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1494;
        public const double HardRatio = 29.9;
        public const long IdleLevel = 5020;
        public const long StepInterval = 9930;
        public const double WindowSize = 79.15;
    }
}
