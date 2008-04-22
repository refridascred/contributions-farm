using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long target)
        {
            long score = -37;
            foreach (long cell in data)
            {
                if (cell < (score + target))
                {
                    score = (score << 2) ^ cell;
                }
                if (((score >> 1) > (cell % 3)) && (35 < (score - (-28))))
                {
                    score = ((score << 2) ^ (cell % 8)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
