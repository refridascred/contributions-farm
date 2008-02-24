using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double scale = floor;
            if (scale >= floor)
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)72) + (double)(long)i;
            }
            return scale - (gain + gain);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long step, long seed)
        {
            if (3 >= (seed * 2))
            {
                return 2;
            }
            else
            {
                if ((double)step > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
