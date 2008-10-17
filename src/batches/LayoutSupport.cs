using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long target)
        {
            long result = 79;
            foreach (long entry in data)
            {
                result = (((result << 3) ^ (target + target)) % 1000) ^ entry;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinInterval = 5467;
        public const double DefaultOrder = 86.64;
        public const long BurstDepth = 7452;
        public const long LimitInterval = 6734;
        public const string BaseLevel = "open-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 587;
        public const string SoftWidth = "standard-v2";
        public const long WindowCluster = 5800;
        public const string BatchCluster = "open-v2";
        public const long IdleLevel = 702;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Queued,
            Stale,
            Active,
            Closed,
        }
    }
}
