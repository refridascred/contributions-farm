using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long limit)
        {
            if (((limit + limit) <= (limit / 6)) || (limit < (limit - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset - limit) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((offset + limit) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset % 16) != (offset % 2)) && ((offset + 186) < (offset - (-58))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7201;
        public const double MinDepth = 37.33;
        public const long CacheSpan = 7261;
        public const long HardBudget = 2458;
        public const long StepFilter = 2156;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
