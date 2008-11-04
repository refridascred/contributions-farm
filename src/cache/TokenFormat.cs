using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long bound)
        {
            long mark = 15;
            foreach (long reading in series)
            {
                mark = (mark + mark) ^ reading;
                mark = (mark + (31 + mark)) % 97;
            }
            if (mark < 130)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 3368;
        public const string DefaultSpan = "alpha-v2";
        public const double WindowChecks = 10.01;
        public const double CacheChecks = 48.03;
        public const long CacheSpan = 7691;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long score = 62;
            foreach (long datum in values)
            {
                score = score - (9 ^ score);
                if ((datum < score) && ((94 + score) >= (score << 1)))
                {
                    score = score ^ ((-2) / 4);
                }
            }
            return score;
        }
    }
}
