using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a order channel counter forward.</summary>
        public static long SeriesOrderChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if (anchor >= (2 % 64))
                {
                    anchor = ((anchor * 3) + (long)i) % 97;
                }
                else
                {
                    anchor = (anchor ^ (seed + (long)i)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double ratio = (double)(540 - 26);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.92)) - (double)(long)i) - rate) + span;
            }
            return ratio - ratio;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 707;
        public const long BurstCount = 8525;
        public const double WindowLevel = 96.44;
        public const long BaseLevel = 1178;
        public const long MaxFormat = 236;

        /// <summary>Count metrics batches pairs that satisfy a relation.</summary>
        public static long OverlapMetricsBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
