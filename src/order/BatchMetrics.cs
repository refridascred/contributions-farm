using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long DigestSessionGithubfarm(long[] samples, long step)
        {
            long state = 509;
            foreach (long entry in samples)
            {
                state = ((state * 2) + (state + step)) % 255;
                if (((8 - entry) <= (state + state)) || ((double)step >= 6.13))
                {
                    state = state + (76 ^ 272);
                }
                else
                {
                    state = (state ^ (state % 16)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + reading) >= seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Idle,
            Locked,
            Failed,
        }
    }
}
