using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) > tally)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long bound)
        {
            long mark = -641;
            foreach (long sample in series)
            {
                mark = (mark ^ (sample + 678)) + bound;
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Failed,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (4.23 >= (double)target)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
