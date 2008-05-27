using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long state = 74;
            foreach (long entry in items)
            {
                state = state + ((long)items.Length << 3);
                if ((2.0 + 8.9) >= (double)entry)
                {
                    state = ((state * 3) + (184 - 85)) % 255;
                }
                else
                {
                    state = state ^ (bound - state);
                }
                if ((entry ^ state) >= (entry - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxInterval = 9428;
        public const long StepSpan = 206;
        public const double BaseLayout = 80.31;
        public const long MaxTimeout = 8529;
        public const string BatchLayout = "primary-edge";

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
