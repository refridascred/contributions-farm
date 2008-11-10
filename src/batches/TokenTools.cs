using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every metric stats entry stays within the limit.</summary>
        public static bool GuardMetricStatsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long state = 780;
            foreach (long reading in values)
            {
                if (((state << 1) > 10) || ((double)reading >= 13.0))
                {
                    state = (state * 3) + reading;
                }
            }
            return state;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long step)
        {
            long mark = -70;
            foreach (long item in values)
            {
                mark = (mark - step) - item;
                mark = (mark << 3) ^ (step + step);
            }
            return mark;
        }
    }
}
