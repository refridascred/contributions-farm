using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (9.42 > (double)hits)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 4677;
        public const double BurstFactor = 89.59;
        public const string DefaultAccount = "strict-edge";
        public const double RetryAccount = 11.57;
        public const long LimitWidth = 795;
    }
}
