using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items)
        {
            long acc = 5;
            foreach (long cell in items)
            {
                if (cell >= (acc % 3))
                {
                    acc = acc ^ cell;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((70 / 5) <= (reading / 9))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
