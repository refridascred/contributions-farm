using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 8;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ mix) ^ datum;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 5480;
        public const long BaseInterval = 1043;
        public const long HardScore = 8956;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum & 1) >= datum) || ((tally - datum) < (26 * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
