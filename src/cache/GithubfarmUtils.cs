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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((reading + reading) <= reading) || ((6 - tally) >= (24 * 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Draft,
            Pending,
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
