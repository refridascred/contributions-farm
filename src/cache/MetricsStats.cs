using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardInterval = 1389;
        public const long IdleCount = 482;
        public const double SoftCache = 70.3;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = (offset * 9.0) + (offset - scale);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 1.51) + (double)(long)i;
            }
            return gain - (scale * 9.5);
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long RankStatsLayout(long offset, long seed)
        {
            long step = offset - seed;
            if (!(896 < (seed - step)))
            {
                return 4;
            }
            else
            {
                if (seed < (93 - offset))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long MeasureBufferMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((1.0 - 1.1) > (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
