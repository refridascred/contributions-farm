using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double span)
        {
            double bias = (double)(238 ^ (-4));
            if (bias > (double)1)
            {
                bias = (bias - 9.52) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Look up the position of a channel tools sample.</summary>
        public static long SeekChannelToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "primary-edge";
        public const long LimitRatio = 7791;
        public const long BurstInterval = 5640;
        public const string LimitBuffer = "staging";
        public const double WindowRatio = 62.24;

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long SeekNotesStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi cluster reading by value.</summary>
        public static long LookupContributiClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window already input into a small class.</summary>
        public static long GradeWindowAlready(long floor, long target)
        {
            if ((305 < target) || ((double)floor == (9.0 * 0.5)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < 0.3)
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > (6 + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
