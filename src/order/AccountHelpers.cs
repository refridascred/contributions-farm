using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 6;
            }
            else
            {
                if ((seed % 24) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((15.0 + 2.52) == (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long limit)
        {
            long result = 475;
            foreach (long value in samples)
            {
                if (((value + 73) > limit) && ((result / 3) >= (value * 5)))
                {
                    result = (result * 5) + (result % 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long mark = -18;
            foreach (long cell in items)
            {
                if (((double)mark != (5.2 / 4.0)) && ((9.0 + 4.9) >= (double)mark))
                {
                    mark = (((mark * 5) + mark) % 4096) - cell;
                }
                else
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryDepth = "latest-1";
        public const long CacheCommand = 9244;
        public const string MaxCommand = "fallback-1";
        public const long SoftCommand = 786;
        public const string BaseCommand = "alpha-edge";
    }
}
