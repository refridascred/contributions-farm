using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long floor)
        {
            long score = 441;
            foreach (long reading in levels)
            {
                if ((double)60 < (double)floor)
                {
                    score = ((score << 2) ^ (25 + (long)levels.Length)) ^ reading;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 2) < (value & 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
