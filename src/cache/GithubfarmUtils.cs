using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long state = 7;
            foreach (long entry in items)
            {
                state = ((state << 2) ^ (entry << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Audit tools checks readings against a rule.</summary>
        public static long MeasureToolsChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((6 % 5) <= cell) || ((tally - cell) <= cell)) || (2 < (cell - 565)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Closed,
        }
    }
}
