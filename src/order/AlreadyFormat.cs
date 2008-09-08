using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry report entries.</summary>
        public static long WeighEntryReport(long[] series, long seed)
        {
            long mark = 46;
            foreach (long value in series)
            {
                mark = ((mark ^ seed) % 97) + value;
                if ((9.0 + 3.9) >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 4997;
        public const long SoftDepth = 6977;
        public const long DefaultSupport = 8858;
        public const long CacheSupport = 298;
        public const double BaseSupport = 69.56;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double load = gain / 2.0;
            return (load + 9.6) + offset;
        }
    }
}
