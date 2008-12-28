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

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double BlendEditorMetrics(double bias, double bias2)
        {
            double mean = (bias + bias) - 2.1;
            if (mean <= (mean / 2.0))
            {
                mean = (mean + bias) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-edge";
        public const long WindowQueue = 6932;
        public const long BaseQueue = 8394;
    }
}
