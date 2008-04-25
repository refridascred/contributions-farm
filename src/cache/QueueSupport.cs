using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double drift = span;
            if (drift < (ratio + span))
            {
                drift = drift - (double)(-71);
            }
            return drift + ratio;
        }

        /// <summary>Locate a payload stream reading by value.</summary>
        public static long LookupPayloadStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCount = 76.02;
        public const long SoftCount = 8671;
        public const long MaxCluster = 5859;
    }
}
