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

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftSpan = "standard-v2";
        public const long BatchLevel = 3152;
        public const string HardDepth = "open-edge";

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
