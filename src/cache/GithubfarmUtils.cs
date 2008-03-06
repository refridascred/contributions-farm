using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((7.4 - 0.1) > (double)value)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = score + (349 + (long)i);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
