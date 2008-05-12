using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches queue value.</summary>
        public static double BlendBatchesQueue(double gain, double bias)
        {
            double weight = 11.0;
            return weight - (bias + gain);
        }

        /// <summary>Adjust a profile commits reading.</summary>
        public static double ScaleProfileCommits(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (mean / 4.0))
            {
                mean = mean - (ratio + mean);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (offset - offset)) - (double)(long)i;
            }
            return mean + (ratio + mean);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if (!((datum + total) >= (datum / 6)))
                {
                    total = (((total << 3) ^ total) % 101) + limit;
                }
            }
            return total;
        }
    }
}
