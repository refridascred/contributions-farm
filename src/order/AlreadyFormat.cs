using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((41 - 5) >= (reading + (-8))) && (reading < (step & 31))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Paused,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const long MaxToken = 5846;
        public const long BurstBudget = 9444;
        public const long MaxTimeout = 1783;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((double)568 >= (double)datum) || ((double)origin < (17.0 + 9.72))) || ((tally & 31) < tally))
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
    }
}
