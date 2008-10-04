using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 1049;
        public const string BurstGraph = "standard-edge";
        public const long IdleGraph = 9521;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Active,
            Done,
            Synced,
            Retry,
        }
    }
}
