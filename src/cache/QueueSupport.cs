using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool GuardGithubfarmMetricsBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Failed,
            New,
            Locked,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((-2) ^ tally) >= (offset - offset))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }
    }
}
