using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio - (double)840;
            }
            else
            {
                ratio = ratio + (ratio * 6.2);
            }
            return ratio + span;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels, long target)
        {
            long anchor = -63;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ (datum & 3)) % 101) - target;
                anchor = anchor ^ (anchor << 3);
                if ((double)anchor != (9.0 * 9.0))
                {
                    anchor = (anchor - (211 % 2)) % 1000;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ (957 & 7)) % 97;
            }
            return anchor;
        }
    }
}
