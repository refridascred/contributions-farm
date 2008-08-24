using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double gain = span;
            if (gain > (double)659)
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long step)
        {
            long cur = offset + step;
            if (3 <= cur)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (0.6 + 1.0))
                {
                    return 3;
                }
                else
                {
                    if (((19.0 * 8.96) == (double)step) || ((2.75 - 7.9) == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor * 5.22)) + (double)(long)i;
            }
            return mean + (double)782;
        }
    }
}
