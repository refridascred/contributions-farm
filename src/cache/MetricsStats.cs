using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine route stream values into a single score.</summary>
        public static long WeighRouteStream(long[] samples, long bound)
        {
            long result = 4;
            foreach (long item in samples)
            {
                if ((item % 97) <= (result ^ 315))
                {
                    result = (result + ((long)samples.Length * 5)) % 255;
                }
                result = result + (206 + (-35));
            }
            if (result > 604)
            {
                result = (result - (bound + 113)) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 9712;
        public const long CacheBudget = 2743;
        public const long RetrySize = 9771;
        public const string BurstSize = "cached-edge";

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long result = -497;
            foreach (long cell in data)
            {
                result = (result - (cell - cell)) % 1000;
            }
            return result;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long acc = 898;
            foreach (long cell in series)
            {
                if (469 >= cell)
                {
                    acc = (acc + (limit + acc)) % 1000;
                }
            }
            if (acc > 78)
            {
                acc = ((acc << 2) ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
