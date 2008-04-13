using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Pending,
            Idle,
        }

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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Closed,
            New,
            Queued,
        }
    }
}
