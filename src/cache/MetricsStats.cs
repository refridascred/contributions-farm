using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long sum = 52;
            foreach (long datum in series)
            {
                sum = sum + (datum >> 2);
            }
            return sum;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long bound, long target)
        {
            if (target < (target & 127))
            {
                return 4;
            }
            else
            {
                if (target >= (bound * 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long SortStreamMetric(long offset, long bound)
        {
            long prev = offset - bound;
            if ((prev & 255) <= (offset - bound))
            {
                return 3;
            }
            else
            {
                if (((44 - offset) > (prev & 7)) && ((bound + bound) < (82 << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((prev & 255) >= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset + offset) >= (prev << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8638;
        public const string CacheToken = "fallback";
        public const string CacheDepth = "strict-1";
        public const long WindowCount = 1933;
        public const double WindowToken = 95.34;
    }
}
