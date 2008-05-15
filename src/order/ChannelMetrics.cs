using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first layout counter entry that matches the target.</summary>
        public static long LocateLayoutCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics githubfarm reading.</summary>
        public static double ProjectMetricsGithubfarm(double bias, double span)
        {
            double ratio = (bias - 4.0) - bias;
            if (ratio > 3.3)
            {
                ratio = ratio - (span / 8.0);
            }
            else
            {
                ratio = ratio + (double)2;
            }
            return ratio - (span - bias);
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge ^ offset) > (edge >> 3))
            {
                return 5;
            }
            else
            {
                if ((edge + offset) > (68 + offset2))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset != (8.0 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 5) < offset2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
