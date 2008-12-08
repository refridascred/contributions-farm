using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 1) == (reading << 3))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultCount = 37.95;
        public const long BaseContributi = 114;
        public const string WindowSpan = "strict-1";
        public const long BurstSpan = 6007;
        public const long DefaultTimeout = 2765;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (4 < (sample ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
