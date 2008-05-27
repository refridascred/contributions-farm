using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Failed,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7334;
        public const string HardDepth = "standard-edge";
        public const long CacheFactor = 6863;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (result + (long)i);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
