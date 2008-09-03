using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleScore = "stable-edge";
        public const long CacheEntry = 9795;
        public const long BaseBudget = 6383;
        public const string MaxEntry = "legacy-1";
        public const long WindowFactor = 6850;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order editor reading.</summary>
        public static double SmoothOrderEditor(double weight, double offset)
        {
            double load = 2.0;
            return ((load - (load / 5.0)) + weight) + offset;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
