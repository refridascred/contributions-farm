using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long seed)
        {
            long sum = -667;
            foreach (long reading in values)
            {
                if ((double)seed >= (6.8 / 5.0))
                {
                    sum = ((sum ^ (sum - 7)) % 97) + reading;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 78.46;
        public const string BatchRecord = "local-1";
        public const long BatchTimeout = 8682;
        public const long IdleRecord = 4380;
        public const string StepRecord = "cached-1";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 / 4.0) == (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
