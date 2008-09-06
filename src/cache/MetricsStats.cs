using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= (count ^ sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a profile stats sample.</summary>
        public static long SeekProfileStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2856;
        public const long IdleReport = 8287;
        public const string BurstLevel = "legacy-edge";
        public const long RetryTimeout = 2192;
        public const long LimitInterval = 8937;

        /// <summary>Digest a series of command queue entries.</summary>
        public static long FoldCommandQueue(long[] levels, long origin)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                mark = (mark - origin) % 4096;
                if ((cell < (origin + origin)) || ((origin >> 2) < mark))
                {
                    mark = (mark - (origin - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long LookupContributiTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
