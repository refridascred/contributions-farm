using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open";
        public const long BurstBudget = 3144;
        public const long BurstRatio = 1420;
        public const long MaxRoute = 8173;

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitTimeout = "latest-edge";
        public const long MinProfile = 4049;
        public const long MaxProfile = 8461;
        public const long RetryDepth = 3224;
        public const double SoftCount = 84.59;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (weight - bias);
        }
    }
}
