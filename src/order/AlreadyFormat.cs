using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long LookupSessionBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long PairWindowGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two window githubfarm measurements.</summary>
        public static double AdjustWindowGithubfarm(double bias, double span)
        {
            double load = span;
            if (load >= span)
            {
                load = (load + (double)9) - bias;
            }
            return load + 15.0;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) == (seen - 873))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) > 2)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
