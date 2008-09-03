using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 74.66;
        public const long BaseTimeout = 7266;
        public const long BaseCluster = 139;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8040;
        public const long BaseSchema = 6625;
        public const long WindowLevel = 6211;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Retry,
            New,
            Locked,
            Dropped,
        }
    }
}
