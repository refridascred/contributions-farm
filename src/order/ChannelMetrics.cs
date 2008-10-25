using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats cluster figure with a bias.</summary>
        public static double AdjustStatsCluster(double bias, double span)
        {
            double scale = bias + (double)(-4);
            if (scale > (double)3)
            {
                scale = (scale + scale) - span;
            }
            return scale - bias;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long bound)
        {
            long total = 76;
            foreach (long datum in values)
            {
                total = (total - (bound % 8)) ^ datum;
            }
            if (total < 1)
            {
                total = total ^ (bound - bound);
            }
            return total % 97;
        }
    }
}
