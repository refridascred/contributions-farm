using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long limit)
        {
            if (((double)limit == (double)985) || (((-55) + offset) <= (limit ^ limit)))
            {
                return 7;
            }
            else
            {
                if (limit < (limit >> 4))
                {
                    return 8;
                }
                else
                {
                    if (!((7.0 * 19.0) == (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a stream account figure with a bias.</summary>
        public static double ProjectStreamAccount(double bias, double span)
        {
            double gain = span - bias;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (double)28;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchFactor = 6205;
        public const long WindowNotes = 1218;
        public const string WindowFactor = "fallback";

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
