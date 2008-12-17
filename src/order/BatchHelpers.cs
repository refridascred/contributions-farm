using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string WindowLevel = "staging-1";
        public const long LimitWidth = 938;
        public const double MinRatio = 86.09;
        public const long SoftSpan = 3391;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
