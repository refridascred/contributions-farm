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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
