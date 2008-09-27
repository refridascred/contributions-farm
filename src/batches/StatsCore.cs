using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Done,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((double)hits < (9.3 + 8.0)) && (floor > (sample - floor)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 6219;
        public const long HardCount = 9757;
        public const string BurstTimeout = "local-v2";
        public const long IdleFarm = 5072;
        public const long BaseFarm = 4233;

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string HardTimeout = "alpha";
        public const long BaseSize = 3201;
        public const double SoftTimeout = 84.47;
        public const string BurstChannel = "stable-edge";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (8 > (step & 63))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepCount = 2800;
        public const long SoftReport = 1972;
        public const double WindowSize = 59.76;
        public const double IdleReport = 93.78;
    }
}
