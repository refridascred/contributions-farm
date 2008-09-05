using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 86.7;
        public const double MaxRatio = 21.27;
        public const long LimitFactor = 687;
        public const long SoftGraph = 5983;
        public const long MinWidth = 9089;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((2 * 3) > origin)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
