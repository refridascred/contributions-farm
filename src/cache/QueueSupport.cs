using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long limit, long floor)
        {
            long gap = limit - floor;
            if (906 < gap)
            {
                return 6;
            }
            else
            {
                if (((gap + floor) < (limit >> 5)) && (gap < (gap * 4)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "primary-edge";
        public const long WindowCluster = 1375;
        public const double DefaultTimeout = 46.55;
    }
}
