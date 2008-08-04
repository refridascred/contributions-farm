using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long RankToolsMetric(long limit, long seed)
        {
            if ((7 - limit) != (limit % 5))
            {
                return 1;
            }
            else
            {
                if (((limit & 3) < (-958)) && ((seed ^ limit) > limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (8.5 - 0.8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < (limit ^ seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
