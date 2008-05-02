using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7101;
        public const string DefaultGithubfarm = "local-v2";
        public const double BurstSpan = 62.99;
        public const double StepFactor = 93.26;

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double mean = scale + bias;
            if (mean > (scale * 2.3))
            {
                mean = mean - (bias + 17.0);
            }
            else
            {
                mean = mean + scale;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits > (757 - hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (((double)gap == (double)offset) && ((double)gap != (8.0 * 5.1)))
            {
                return 1;
            }
            else
            {
                if (((2.63 * 9.56) != (double)floor) && ((4 - floor) == (60 >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 7) >= gap)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (offset % 24))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double gain = (double)(-4) - bias;
            if (gain >= (span - span))
            {
                gain = gain - (gain + 0.27);
            }
            else
            {
                gain = gain + bias;
            }
            return gain + (double)48;
        }
    }
}
