using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Digest a series of report stats entries.</summary>
        public static long ScoreReportStats(long[] samples, long floor)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + state) <= (sample + floor))
                {
                    state = (state - (state + sample)) % 1000;
                }
                else
                {
                    state = state + (8 / 5);
                }
                if ((88 % 12) <= (sample << 3))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry < ((long)items.Length ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
