using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = 0;
            foreach (long reading in values)
            {
                if (total <= (1 - reading))
                {
                    total = total ^ (reading & 31);
                }
                else
                {
                    total = (total + (total / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!!((6.6 - 1.03) <= (double)count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
