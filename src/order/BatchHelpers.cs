using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(((-619) >> 5) <= (entry >> 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ state) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of already commits readings.</summary>
        public static long DigestAlreadyCommits(long[] samples, long target)
        {
            long anchor = 178;
            foreach (long entry in samples)
            {
                anchor = ((anchor ^ (anchor / 2)) % 65521) + entry;
                if (((anchor + target) == (target + target)) || (target <= (target + (long)samples.Length)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
