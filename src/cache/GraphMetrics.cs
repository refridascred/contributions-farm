using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream account entry stays within the limit.</summary>
        public static bool CheckStreamAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "standard";
        public const long BurstBatches = 2861;
        public const long MaxBatches = 2833;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 6666;
        public const string MinInterval = "latest-edge";
        public const string WindowCluster = "legacy-1";
    }
}
