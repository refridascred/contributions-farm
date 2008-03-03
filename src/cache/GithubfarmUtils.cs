using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit graph already readings against a rule.</summary>
        public static long TallyGraphAlreadyOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((1 >> 3) <= limit)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Roll a context checks counter forward.</summary>
        public static long StepContextChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
