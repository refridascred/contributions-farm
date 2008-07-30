using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)967)
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry commits value against two limits.</summary>
        public static long ClassifyEntryCommits(long origin, long offset)
        {
            if ((150 + origin) <= origin)
            {
                return 5;
            }
            else
            {
                if ((origin & 15) != ((-985) - offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 97;
                score = (score << 2) ^ (target - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of cache layout readings.</summary>
        public static long DigestCacheLayout(long[] samples)
        {
            long mix = -72;
            foreach (long datum in samples)
            {
                if (mix < (datum - datum))
                {
                    mix = mix + (mix ^ datum);
                }
            }
            return mix % 4096;
        }
    }
}
