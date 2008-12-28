using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "latest-v2";
        public const long DefaultRatio = 5936;
        public const string IdleFactor = "local-edge";

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) <= matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
