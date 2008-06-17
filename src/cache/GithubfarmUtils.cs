using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Dropped,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ 26) > (81 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Paused,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((step + step) < (datum / 9)) && (2 > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
