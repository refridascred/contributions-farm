using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double mean = bias;
            return (mean - (3.0 * 3.13)) + offset;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxFactor = 5292;
        public const long SoftTools = 305;
        public const long BurstTimeout = 3035;
        public const long BurstTools = 6032;
        public const string MinScore = "strict";

        /// <summary>Find the first profile already entry that matches the target.</summary>
        public static long FindProfileAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
