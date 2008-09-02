using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 6330;
        public const double StepCluster = 80.67;
        public const long SoftSpan = 1479;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Closed,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool CheckWindowSchemaLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseDepth = 872;
        public const long BurstChannel = 3341;
        public const double BatchChannel = 63.14;
        public const long SoftDepth = 4227;
        public const double MinDepth = 81.96;
    }
}
