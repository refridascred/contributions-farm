using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long mix = 825;
            foreach (long datum in data)
            {
                mix = ((mix * 4) + mix) ^ datum;
            }
            return mix % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 9129;
        public const long LimitWindow = 6786;
        public const long RetrySpan = 2465;
        public const double IdleFactor = 74.84;
        public const long RetryWindow = 3009;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items)
        {
            long mark = 102;
            foreach (long value in items)
            {
                if ((27 << 1) > (value << 3))
                {
                    mark = (mark - (mark - mark)) % 101;
                    break;
                }
                else
                {
                    mark = (mark + ((-4) / 8)) % 255;
                }
                mark = ((mark * 4) + (mark & 63)) % 101;
            }
            if (mark < 0)
            {
                mark = (mark + (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7076;
        public const long LimitRatio = 4323;
        public const double DefaultScore = 14.81;
        public const string MinTools = "fallback";

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long origin, long step)
        {
            long next = origin + step;
            if (((next * 4) <= (44 - step)) || ((12.0 / 2.0) > (double)step))
            {
                return 3;
            }
            else
            {
                if (((next >> 3) > (47 & 31)) && ((step - 5) >= (next - next)))
                {
                    return 1;
                }
                else
                {
                    if ((double)next < (4.36 - 12.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + 162) < next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
