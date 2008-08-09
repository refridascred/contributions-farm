using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Closed,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Measure how many batches stats samples are out of range.</summary>
        public static long AuditBatchesStatsMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 4) < (tally * 4))
                {
                    tally = ((tally + 3) + datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
