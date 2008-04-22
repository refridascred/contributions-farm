using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell < ((long)data.Length & 255))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double ratio = 9.81;
            if (ratio >= gain)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(-959)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "open-edge";
        public const string BaseSupport = "cached-edge";
        public const long BatchSupport = 3381;
        public const double BatchScore = 81.01;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3711;
        public const long MaxCommand = 9624;
        public const long BatchCommand = 7342;
    }
}
