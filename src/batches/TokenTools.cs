using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch stats sample.</summary>
        public static long SeekBatchStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double gain = scale;
            if (gain <= span)
            {
                gain = gain + (gain / 5.0);
            }
            return gain - (3.1 * 5.44);
        }

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool CheckChannelCommitsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
