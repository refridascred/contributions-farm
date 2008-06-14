using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= (299 % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinSize = 17.07;
        public const long SoftRatio = 5827;
        public const double LimitScore = 74.3;
        public const double BatchPayload = 66.23;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Synced,
            Pending,
            Idle,
            Active,
        }
    }
}
