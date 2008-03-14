using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (9.3 >= (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardTimeout = 376;
        public const long BaseLayout = 4673;
        public const long WindowSize = 5424;
        public const double RetryLayout = 89.14;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Audit checks context readings against a rule.</summary>
        public static long CountChecksContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((origin + 53) < (-27))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
