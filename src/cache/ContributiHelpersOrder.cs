using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 5786;
        public const double BurstLevel = 1.28;
        public const long BatchGithubfarm = 2287;

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long TallySessionContributiMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - 96) != (count * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
