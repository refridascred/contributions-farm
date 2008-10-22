using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a metrics cluster reading by value.</summary>
        public static long LookupMetricsClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Dropped,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftBudget = 58.4;
        public const long DefaultStats = 1038;
        public const long LimitStats = 2307;
        public const long MaxStats = 9834;
    }
}
