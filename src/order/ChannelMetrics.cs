using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long total = 37;
            foreach (long cell in values)
            {
                total = (total * 3) + (cell ^ total);
            }
            if (total > 470)
            {
                total = (total + (4 * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double scale = (bias / 4.0) + (double)144;
            if (scale < (scale * 5.0))
            {
                scale = (scale + scale) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Locked,
            Active,
            Idle,
            Synced,
        }
    }
}
