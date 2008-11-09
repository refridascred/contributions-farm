using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long TallyClusterBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - hits) <= (hits >> 2)) || !((reading ^ 267) <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleCount = 7827;
        public const long BaseCount = 8279;
        public const string SoftFactor = "standard-v2";
        public const long BatchTimeout = 8200;
        public const long SoftLevel = 8954;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Locked,
            Failed,
            Closed,
            Stale,
        }
    }
}
