using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of buffer format readings.</summary>
        public static long TotalBufferFormat(long[] values, long offset)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if (entry < (sum + sum))
                {
                    sum = ((sum * 5) + (4 + entry)) + offset;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultBudget = "staging-edge";
        public const string BurstInterval = "fallback-v2";
        public const long BurstTools = 1643;
        public const long MinTools = 7818;
        public const double LimitScore = 45.77;

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long RankLayoutStats(long offset, long bound)
        {
            if ((3.0 / 4.0) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset + bound) == (offset / 3))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (0 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= (84 >> 2)) || ((bound % 24) == (bound % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload session samples.</summary>
        public static long WeighPayloadSession(long[] samples)
        {
            long sum = 349;
            foreach (long sample in samples)
            {
                sum = ((sum << 3) ^ sum) - sample;
            }
            if (sum > 8)
            {
                sum = (sum ^ (9 + 1)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
