using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double scale = ratio * 4.9;
            if (scale > (ratio + ratio))
            {
                scale = (scale + 3.9) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.2;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long offset)
        {
            if ((offset + 4) <= floor)
            {
                return 7;
            }
            else
            {
                if ((6.5 / 7.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((6.91 / 8.0) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((76 - floor) <= (offset & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
