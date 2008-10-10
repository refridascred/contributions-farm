using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((2.5 * 8.0) < (double)cell) && ((tally >= (cell & 7)) || ((18.0 - 8.26) > (double)(long)values.Length)))
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (1 & 1))
                {
                    matches = ((matches + 3) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultInterval = 84.8;
        public const double SoftSize = 11.97;
        public const long HardGithubfarm = 8026;
        public const long MinGithubfarm = 5181;
        public const long MinTimeout = 9389;
    }
}
