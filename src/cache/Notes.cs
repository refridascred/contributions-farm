using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if ((bound / 5) < bound)
            {
                return 2;
            }
            else
            {
                if ((bound * 4) > (bound << 2))
                {
                    return 1;
                }
                else
                {
                    if (!(bound2 >= (bound2 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (179 >= bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long LookupBatchesContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "strict-v2";
        public const double BaseSize = 85.79;
        public const long RetryEntry = 2735;
        public const long MinEntry = 2136;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 66.63;
        public const long BurstCache = 5467;
        public const double MinSize = 20.84;
        public const long BatchInterval = 5464;
    }
}
