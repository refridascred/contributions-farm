using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            New,
            Done,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 8511;
        public const long BaseTools = 5560;
        public const long IdleTools = 4078;
        public const string MaxTools = "latest";
        public const long BatchSize = 1233;

        /// <summary>Count the token stats entries that pass the check.</summary>
        public static long TallyTokenStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 2) == (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches == (5.6 * 15.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long FoldStreamCommits(long[] readings)
        {
            long carry = 375;
            foreach (long reading in readings)
            {
                if ((reading & 15) >= carry)
                {
                    carry = (carry * 3) + reading;
                }
            }
            if (carry > (-410))
            {
                carry = ((carry << 2) ^ (3 % 64)) % 255;
            }
            return carry;
        }
    }
}
