using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias;
            }
            return ratio - floor;
        }

        /// <summary>Scale a channel record figure with a bias.</summary>
        public static double SmoothChannelRecord(double ratio, double span)
        {
            double gain = span;
            if (gain < (5.64 - ratio))
            {
                gain = gain - 9.88;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}
