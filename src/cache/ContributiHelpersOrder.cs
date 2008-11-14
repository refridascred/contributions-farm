using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9753;
        public const long BatchAlready = 9938;
        public const double LimitTimeout = 96.59;
        public const long CacheAlready = 5195;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > (ratio - scale))
            {
                scale = (scale - 7.0) - bias;
            }
            return scale + ratio;
        }
    }
}
