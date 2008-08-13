using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 71.45;
        public const long MinInterval = 5197;
        public const long DefaultSize = 1479;
        public const long WindowStats = 4724;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long span = seed + origin;
            if (seed < (origin / 7))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) >= (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (span >= 792)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two buffer metrics measurements.</summary>
        public static double ScaleBufferMetrics(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (bias2 + 2.0))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (double)62;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 9.0) + (double)(long)i;
            }
            return mean - (double)677;
        }
    }
}
