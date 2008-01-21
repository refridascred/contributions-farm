using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 6811;
        public const long DefaultInterval = 6173;
        public const long MaxSize = 3030;
        public const string DefaultOrder = "stable-edge";
    }
}
