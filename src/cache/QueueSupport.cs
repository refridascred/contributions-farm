using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report graph samples are out of range.</summary>
        public static long AuditReportGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long TotalGithubfarmReport(long[] readings)
        {
            long mark = 8;
            foreach (long cell in readings)
            {
                if (mark <= (217 >> 5))
                {
                    mark = (mark ^ cell) % 101;
                }
                else
                {
                    mark = mark ^ cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "stable-v2";
        public const long BaseFormat = 4921;
        public const string MinFormat = "alpha-1";
        public const long BatchFormat = 4263;
    }
}
