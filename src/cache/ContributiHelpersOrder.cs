using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "local-1";
        public const long WindowChannel = 391;
        public const long RetryTimeout = 6663;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= 3.6)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long ScoreStatsGithubfarm(long[] readings, long origin)
        {
            long result = 978;
            foreach (long value in readings)
            {
                result = (((result * 4) + origin) % 1000) - value;
                result = result + origin;
            }
            return result;
        }
    }
}
