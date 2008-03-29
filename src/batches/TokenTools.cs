using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "legacy";
        public const long BatchSpan = 2765;
        public const long DefaultCluster = 7562;
        public const long LimitFactor = 1489;
        public const double BatchCluster = 97.12;
    }
}
