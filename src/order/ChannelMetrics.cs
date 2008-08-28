using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format command entries.</summary>
        public static long FoldFormatCommand(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix << 1)) + value;
            }
            if (mix > 70)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next githubfarm batches value.</summary>
        public static double AdjustGithubfarmBatches(double gain, double span)
        {
            double scale = (gain - span) + (gain / 8.0);
            if (scale <= 11.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - (double)2;
        }
    }
}
