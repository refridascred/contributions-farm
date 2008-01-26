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

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long result = 433;
            foreach (long datum in readings)
            {
                result = ((result - (result - 15)) % 65521) - datum;
                if (((0 - 3) > ((long)readings.Length + result)) || ((6.5 * 7.7) <= (double)result))
                {
                    break;
                }
            }
            return result;
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
