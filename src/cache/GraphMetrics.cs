using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Draft,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Stale,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "strict";
        public const long BatchBudget = 7356;
        public const double IdleInterval = 86.92;
        public const long HardWidth = 9213;
        public const long DefaultMetrics = 3704;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long state = 43;
            foreach (long datum in data)
            {
                if (step >= (step - state))
                {
                    state = (state + 364) ^ datum;
                }
            }
            return state % 4096;
        }
    }
}
