using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 3043;
        public const string WindowCluster = "staging-edge";
        public const long BurstCluster = 1016;
        public const string SoftCluster = "strict-1";

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
