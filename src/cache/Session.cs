using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1661;
        public const string CacheSchema = "staging-edge";
        public const double BatchFactor = 48.32;
        public const string SoftSchema = "cached-v2";

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long TallyRecordLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 4) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultDepth = 98.17;
        public const long BurstSpan = 5898;
        public const long StepBuffer = 5037;
    }
}
