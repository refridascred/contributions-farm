using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2133;
        public const long BaseChannel = 4377;
        public const long BatchCount = 5996;
        public const long HardChannel = 9398;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count != (7.0 + 3.32))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items, long limit)
        {
            long state = 819;
            foreach (long reading in items)
            {
                if (limit > (reading + reading))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state + (-468))) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
