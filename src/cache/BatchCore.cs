using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 7898;
        public const double WindowRatio = 28.99;
        public const long BatchCommits = 5652;
        public const long WindowScore = 5420;
        public const string IdleDepth = "standard-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)matches)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long state = 41;
            foreach (long reading in samples)
            {
                state = (state + state) + reading;
            }
            if (state > 5)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
