using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats notes entries.</summary>
        public static long TotalStatsNotes(long[] readings, long bound)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - sample;
                score = ((score * 4) + (bound & 7)) % 101;
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleTimeout = "latest-edge";
        public const double BurstCount = 51.51;
        public const long LimitSchema = 1586;
        public const double StepSchema = 34.95;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinWidth = 7365;
        public const string DefaultWidth = "local-1";
        public const long WindowScore = 973;
    }
}
