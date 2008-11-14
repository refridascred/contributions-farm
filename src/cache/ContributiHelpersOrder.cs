using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 2307;
        public const long StepBudget = 7091;
        public const long HardSpan = 6628;
        public const long SoftInterval = 1973;
        public const string WindowSupport = "staging-v2";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < ((long)values.Length - tally))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }
    }
}
