using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((floor - floor) >= (hits >> 1)) || (((floor / 3) >= (hits % 12)) || ((entry + floor) == (hits >> 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "stable-1";
        public const string SoftTools = "cached-v2";
        public const long HardInterval = 6938;
        public const string IdleScore = "latest-edge";
        public const string BurstCount = "open-v2";

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            New,
            Dropped,
        }
    }
}
