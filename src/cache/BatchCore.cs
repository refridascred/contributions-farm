using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (9.0 >= (double)offset)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 525;
        public const string BurstDepth = "open";
        public const long MinCommand = 3234;
        public const string IdleCommand = "open-1";
        public const long RetryDepth = 6046;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
