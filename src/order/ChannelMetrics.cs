using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 874;
        public const long BurstCommits = 4042;
        public const long SoftCommits = 8730;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long origin)
        {
            long delta = offset ^ origin;
            if ((delta + origin) < delta)
            {
                return 0;
            }
            else
            {
                if ((double)5 >= (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 2) == (delta * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double mean = (double)406 * 7.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (double)43) + (double)(long)i) - rate;
            }
            return mean + offset;
        }
    }
}
