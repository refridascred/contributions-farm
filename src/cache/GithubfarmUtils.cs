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

        /// <summary>Adjust a counter order reading.</summary>
        public static double ScaleCounterOrder(double rate, double bias)
        {
            double load = rate;
            if (load > load)
            {
                load = load - (rate / 4.0);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - (bias - load);
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
