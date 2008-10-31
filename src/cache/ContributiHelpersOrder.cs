using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Ready,
            Active,
            New,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 6642;
        public const double StepTimeout = 56.95;
        public const double LimitRatio = 10.56;
        public const double WindowGithubfarm = 6.72;

        /// <summary>Compare every pair of checks profile readings.</summary>
        public static long CompareChecksProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
