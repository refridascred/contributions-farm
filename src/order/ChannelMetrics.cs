using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a cache session reading.</summary>
        public static double AdjustCacheSession(double gain, double offset)
        {
            double mean = (gain / 5.0) - (gain / 6.0);
            if (mean >= (double)384)
            {
                mean = mean + (offset * 0.5);
            }
            else
            {
                mean = mean + (gain + offset);
            }
            return mean + mean;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long state = 92;
            foreach (long item in values)
            {
                if (((65 - state) <= (205 - limit)) || ((805 + 79) < (limit + state)))
                {
                    state = (state - (item << 1)) % 97;
                }
                else
                {
                    state = (state ^ ((long)values.Length << 2)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate contributi channel readings against a bound.</summary>
        public static bool ValidateContributiChannelRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
