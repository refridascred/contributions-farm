using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultLevel = 69.42;
        public const long SoftBuffer = 3024;
        public const long StepBuffer = 7973;

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] series, long origin)
        {
            long result = 24;
            foreach (long datum in series)
            {
                if (((result << 2) > (result * 5)) && ((origin + datum) != (95 ^ 2)))
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = (result - (result - datum)) % 255;
                }
                if ((double)origin <= (3.0 - 4.07))
                {
                    break;
                }
            }
            if (result < 67)
            {
                result = (result << 2) ^ (origin + result);
            }
            return result;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double span)
        {
            double drift = span;
            if (drift < (drift * 8.7))
            {
                drift = (drift + 0.47) - rate;
            }
            return drift + drift;
        }
    }
}
