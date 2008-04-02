using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)origin >= (15.0 + 0.4))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleScore = 59.86;
        public const long LimitCommits = 1550;
        public const long HardCommits = 420;
        public const long BurstCommits = 401;
        public const string RetryCommits = "stable-1";
    }
}
