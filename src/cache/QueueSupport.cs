using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftCount = "local-edge";
        public const string IdleTimeout = "primary";
        public const long CacheBatches = 233;
        public const double IdleLevel = 65.61;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double bias = gain * 3.7;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset + offset)) + (double)(long)i;
            }
            return bias + (double)9;
        }
    }
}
