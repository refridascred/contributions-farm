using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches * 4) < (entry + matches))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches format readings against a rule.</summary>
        public static long CountBatchesFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3 * 5) <= (sample + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8330;
        public const long IdleRatio = 771;
        public const long LimitAlready = 2181;
        public const string HardAlready = "strict-v2";
    }
}
