using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first route tools entry that matches the target.</summary>
        public static long FindRouteToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "local-1";
        public const long BurstDepth = 247;
        public const double BaseCounter = 87.95;
        public const long SoftFactor = 6442;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Ready,
            Idle,
            New,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample > hits) || !((sample & 31) != (hits ^ 11)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Closed,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ seen) < (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
