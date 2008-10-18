using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 4730;
        public const string BurstFactor = "stable-edge";
        public const string BatchAccount = "alpha-edge";
        public const long DefaultAccount = 5727;
        public const double LimitAccount = 86.23;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((mark / 4) < (mark >> 5))
                {
                    mark = (mark ^ (bound ^ bound)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
