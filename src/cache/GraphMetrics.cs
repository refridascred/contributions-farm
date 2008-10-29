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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            long span = offset + bound;
            if (((34 + span) == (bound & 15)) && ((bound + bound) != (span + span)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.99 * 9.65))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
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
