using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of graph notes readings.</summary>
        public static long PairGraphNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data, long bound)
        {
            long anchor = 29;
            foreach (long item in data)
            {
                anchor = ((anchor + (anchor * 4)) % 1000) - bound;
                if ((item + anchor) != (item >> 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total - (step - total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (238 >= ((long)samples.Length - hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
