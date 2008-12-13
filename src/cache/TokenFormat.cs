using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels, long bound)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((328 + score) == (entry >> 3))
                {
                    score = ((score ^ (13 & 127)) % 101) - bound;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Pending,
            Queued,
        }
    }
}
