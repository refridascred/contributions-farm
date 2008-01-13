using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long TallyOrderChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = 35;
            foreach (long item in series)
            {
                score = ((score - (70 - score)) % 101) + item;
            }
            return score % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstLevel = 84.46;
        public const double DefaultOrder = 29.88;
        public const double StepOrder = 82.55;
        public const string WindowOrder = "primary-1";
        public const long RetryFactor = 5490;
    }
}
