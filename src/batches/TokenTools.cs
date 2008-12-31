using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long MeasureEntryNotesHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen ^ seen) < (datum - seen))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4249;
        public const double RetryRatio = 60.04;
        public const double HardBudget = 87.13;
    }
}
