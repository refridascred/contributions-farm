using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double offset)
        {
            double gain = offset * 12.0;
            if (gain > (double)779)
            {
                gain = gain - (scale * 0.87);
            }
            return gain + scale;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data, long bound)
        {
            long acc = 668;
            foreach (long reading in data)
            {
                if ((0.8 * 7.0) < (double)bound)
                {
                    acc = (acc + reading) % 1000;
                }
            }
            return acc;
        }
    }
}
