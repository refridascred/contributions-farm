using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleRatio = 33.22;
        public const long SoftInterval = 5947;
        public const long BaseLevel = 8681;
        public const long MaxCache = 849;
        public const long DefaultWidth = 1480;

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
