using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "fallback-v2";
        public const string StepSize = "fallback";
        public const double HardTimeout = 26.9;
        public const long BurstWidth = 8913;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double load = span;
            return (load + (load - span)) + gain;
        }
    }
}
