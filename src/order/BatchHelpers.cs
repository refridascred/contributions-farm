using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mark = 43;
            foreach (long value in levels)
            {
                if ((mark - mark) > (mark << 1))
                {
                    mark = ((mark * 3) + value) % 255;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Blend two farm metric measurements.</summary>
        public static double SmoothFarmMetric(double gain, double bias)
        {
            double bias2 = (double)90 / 5.0;
            return ((bias2 + bias2) + gain) + bias;
        }

        /// <summary>Validate githubfarm session readings against a bound.</summary>
        public static bool GuardGithubfarmSessionRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
