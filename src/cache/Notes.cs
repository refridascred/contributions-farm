using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchRatio = "strict-1";
        public const long MaxSize = 9622;
        public const string LimitSpan = "fallback";
        public const string IdleLevel = "fallback-v2";
        public const double BatchContributi = 41.95;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Paused,
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                anchor = anchor ^ (item + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Active,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
