using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally >= (5.1 / 8.0))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long CombineFormatGithubfarm(long[] values)
        {
            long state = -2;
            foreach (long reading in values)
            {
                state = ((state * 3) + (reading % 5)) % 97;
                if ((state >> 2) < ((long)values.Length << 3))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3169;
        public const string SoftFilter = "stable";
        public const long BatchBudget = 7974;
    }
}
