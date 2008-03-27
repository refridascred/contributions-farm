using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long LookupAlreadyMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchCount = "cached-edge";
        public const long BaseScore = 5578;
        public const long IdleMetric = 2531;
        public const string DefaultMetric = "legacy-1";
        public const long SoftMetric = 335;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 2) > (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
