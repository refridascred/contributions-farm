using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5086;
        public const double MinWindow = 87.43;
        public const string DefaultWindow = "staging-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowScore = 302;
        public const string LimitWidth = "alpha-1";
        public const long HardSpan = 3327;
        public const double BurstScore = 80.53;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
