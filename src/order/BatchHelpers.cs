using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-v2";
        public const long WindowScore = 5677;
        public const string WindowEntry = "fallback-1";
        public const string LimitEntry = "fallback-v2";

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Draft,
            Queued,
            Closed,
        }
    }
}
