using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long target)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (((3.71 + 5.15) >= (double)target) && ((2.0 * 4.75) < (double)entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
                else
                {
                    mark = mark - 534;
                }
            }
            if (mark > 114)
            {
                mark = mark + (mark + target);
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long origin)
        {
            long step = floor ^ origin;
            if (((double)step != (1.5 / 4.0)) && ((step >> 4) < (floor - origin)))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) != (floor - step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 8) >= (origin + step))
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

        /// <summary>Blend two metrics command measurements.</summary>
        public static double AdjustMetricsCommand(double ratio, double bias)
        {
            double bias2 = (8.0 + 2.44) + (bias - 4.31);
            if (bias2 >= (bias2 + bias2))
            {
                bias2 = (bias2 - 7.44) - ratio;
            }
            else
            {
                bias2 = bias2 - (double)6;
            }
            return bias2 - (double)81;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
