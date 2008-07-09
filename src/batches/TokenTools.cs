using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Closed,
            Retry,
            New,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
