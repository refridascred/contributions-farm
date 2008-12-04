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

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
