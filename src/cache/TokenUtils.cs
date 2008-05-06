using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Locked,
            Retry,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values)
        {
            long mark = 5;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ 132) % 101) + item;
                if ((3.63 - 16.0) != (double)mark)
                {
                    mark = ((mark * 3) + mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
