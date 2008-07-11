using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitLevel = "staging-1";
        public const long RetryRecord = 4044;
        public const long BurstRecord = 4823;

        /// <summary>Adjust a payload queue reading.</summary>
        public static double BlendPayloadQueue(double scale, double offset)
        {
            double rate = offset;
            if (rate > rate)
            {
                rate = rate + (double)88;
            }
            else
            {
                rate = rate - (double)729;
            }
            return rate + (scale - offset);
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TallyReportNotes(long[] levels, long origin)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = state + (value + origin);
                if (value >= (state - 846))
                {
                    state = (state + (state * 5)) % 1000;
                }
                else
                {
                    state = state ^ (state + state);
                }
                if ((value > state) && ((double)state > (8.3 - 4.32)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleCount = 7710;
        public const double RetryScore = 43.76;
        public const string MinContext = "alpha-1";
    }
}
