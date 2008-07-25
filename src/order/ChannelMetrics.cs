using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine command metric values into a single score.</summary>
        public static long FoldCommandMetric(long[] series, long limit)
        {
            long state = 96;
            foreach (long datum in series)
            {
                if ((state + limit) < (datum & 31))
                {
                    state = state - (datum << 2);
                }
            }
            return state;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Stale,
            Paused,
        }
    }
}
