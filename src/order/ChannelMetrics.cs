using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 48.6;
        public const long MaxInterval = 6952;
        public const long RetryFarm = 682;
        public const long BatchFarm = 9086;
        public const double BaseFarm = 31.22;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long origin)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((95 + mix) == (sample + sample))
                {
                    mix = ((mix + (mix % 5)) % 65521) - origin;
                }
            }
            return mix;
        }
    }
}
