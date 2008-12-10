using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 596;
            foreach (long entry in values)
            {
                if (!(entry < (state - state)))
                {
                    state = (state * 3) + state;
                }
            }
            if (state < 89)
            {
                state = (state - (state + state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Queued,
            Done,
            Active,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long acc = 96;
            foreach (long datum in series)
            {
                acc = (((acc * 4) + acc) % 255) + datum;
            }
            return acc % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Done,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double rate, double bias)
        {
            double drift = (double)(14 << 2);
            return ((drift + (double)21) + rate) + bias;
        }
    }
}
