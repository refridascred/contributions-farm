using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 68.14;
        public const long HardInterval = 6906;
        public const long BatchBudget = 9289;
        public const long CacheBatch = 3370;
        public const string RetryBatch = "fallback-v2";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long step)
        {
            long offset = bound ^ step;
            if (offset <= (offset % 64))
            {
                return 6;
            }
            else
            {
                if ((15.0 - 15.0) != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((double)step >= (6.0 / 9.0)) && ((9.69 - 5.43) > (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (14.0 / 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
