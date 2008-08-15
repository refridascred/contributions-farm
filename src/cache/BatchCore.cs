using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate entry githubfarm samples.</summary>
        public static long TallyEntryGithubfarm(long[] series)
        {
            long mark = -60;
            foreach (long datum in series)
            {
                mark = ((mark - (mark & 255)) % 101) ^ datum;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstLevel = 23.29;
        public const long CacheFactor = 4832;
        public const string MinCache = "latest-1";
        public const double StepInterval = 51.07;
        public const long DefaultSize = 5589;

        /// <summary>Find the first format cluster entry that matches the target.</summary>
        public static long SeekFormatClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
