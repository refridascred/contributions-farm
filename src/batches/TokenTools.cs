using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a token graph reading by value.</summary>
        public static long LocateTokenGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift - (drift / 7.0);
            }
            return drift - span;
        }
    }
}
