using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double rate2 = (double)(88 * 3);
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + (rate2 + rate2)) + (double)(long)i) - bias;
            }
            return rate2 + (17.0 - rate);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2135;
        public const double IdleTools = 72.87;
        public const double CacheInterval = 80.63;
    }
}
