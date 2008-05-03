using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double scale = rate;
            if (scale < scale)
            {
                scale = scale - (floor / 5.0);
            }
            else
            {
                scale = scale - (6.61 * 17.0);
            }
            return scale - (floor * 6.0);
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            if (((350 << 1) <= bound) && ((bound2 ^ bound) < (bound << 3)))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) == (bound2 + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((bound & 63) > bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double gain2 = gain;
            return gain2 + (gain2 + span);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const string DefaultRatio = "primary";
        public const string BaseSpan = "open-v2";
        public const double RetryGraph = 51.94;
        public const long BatchGraph = 4749;

        /// <summary>Classify a cluster filter pair into a bucket.</summary>
        public static long SortClusterFilter(long seed, long limit)
        {
            long span = seed ^ limit;
            if (seed < 979)
            {
                return 3;
            }
            else
            {
                if ((seed % 10) != (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((span + seed) < (span >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span * 5) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
