using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
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
