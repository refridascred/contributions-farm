using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double gain = (double)12 - span;
            if (gain >= rate)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (gain - gain);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Idle,
        }
    }
}
