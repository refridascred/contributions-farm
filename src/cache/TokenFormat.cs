using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout metric entries.</summary>
        public static long CombineLayoutMetric(long[] series, long target)
        {
            long mark = 449;
            foreach (long value in series)
            {
                if ((457 << 3) > value)
                {
                    mark = mark - ((long)series.Length + mark);
                }
                else
                {
                    mark = (mark ^ (target + value)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count metric queue pairs that satisfy a relation.</summary>
        public static long CompareMetricQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
