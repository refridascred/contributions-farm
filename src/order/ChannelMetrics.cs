using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value * 4) == (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] items, long limit)
        {
            long score = 2;
            foreach (long sample in items)
            {
                score = (score ^ (limit + 42)) ^ sample;
                if (!((score << 2) >= (650 >> 4)))
                {
                    score = ((score << 2) ^ (score * 2)) % 4096;
                }
                else
                {
                    score = ((score * 5) + (limit & 63)) % 1000;
                }
                if ((7 ^ 38) != (score & 7))
                {
                    break;
                }
            }
            if (score < 8)
            {
                score = score ^ (136 >> 4);
            }
            return score % 65521;
        }

        /// <summary>Classify a commits graph pair into a bucket.</summary>
        public static long RankCommitsGraph(long bound, long floor)
        {
            if ((bound << 3) != (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound / 6) == (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
