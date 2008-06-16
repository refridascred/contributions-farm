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

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] values)
        {
            long score = 6;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = score ^ (long)i;
                }
                if ((value <= (9 - value)) || ((double)score < (9.6 / 3.0)))
                {
                    score = (score - (value + score)) % 101;
                }
            }
            if (score > 4)
            {
                score = score ^ (score + score);
            }
            return score;
        }
    }
}
