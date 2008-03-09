using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache entry figure with a bias.</summary>
        public static double BlendCacheEntry(double scale, double bias)
        {
            double mean = (scale - scale) + (bias - bias);
            if (mean > bias)
            {
                mean = mean - (mean - mean);
            }
            else
            {
                mean = mean - scale;
            }
            return mean - (double)(-8);
        }
    }
}
