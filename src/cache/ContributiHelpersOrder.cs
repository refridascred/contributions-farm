using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "standard-edge";
        public const long DefaultFactor = 3130;
        public const string CacheSpan = "local-v2";
        public const string BaseScore = "local-1";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((20 + datum) > ((long)levels.Length << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
