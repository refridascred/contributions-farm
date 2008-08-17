using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (limit / 9)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 2) + (110 & 127)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long seed)
        {
            long anchor = 25;
            foreach (long item in values)
            {
                anchor = (anchor ^ anchor) + item;
                if ((anchor << 1) > anchor)
                {
                    break;
                }
            }
            if (anchor > 481)
            {
                anchor = (anchor + (seed + seed)) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 8;
            foreach (long sample in items)
            {
                anchor = (((anchor << 3) ^ (anchor + anchor)) % 65521) - sample;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 829;
        public const long LimitMetrics = 4371;
        public const double SoftSize = 58.22;
    }
}
