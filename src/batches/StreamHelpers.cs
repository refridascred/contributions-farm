using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + 2) <= (item - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long span = floor - limit;
            if (((-5) + floor) > limit)
            {
                return 8;
            }
            else
            {
                if ((span <= (2 ^ limit)) || (limit <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit <= (double)9) || (floor <= (limit / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((span + span) <= (span - 922)) || ((floor + floor) <= (12 - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two layout graph measurements.</summary>
        public static double SmoothLayoutGraph(double rate, double offset)
        {
            double rate2 = (9.0 + 2.1) - (double)70;
            if (rate2 >= rate)
            {
                rate2 = rate2 + (offset - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - 5.1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset2 + offset) >= (65 - offset))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) >= (offset ^ offset2))
                {
                    return 5;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 / 7) != (offset2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 4.19;
        public const double HardCluster = 46.08;
        public const double MinCluster = 37.4;
        public const double CacheSize = 78.76;
    }
}
