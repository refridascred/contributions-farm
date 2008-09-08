using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool VerifyGithubfarmCommandRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + 89) >= ((long)series.Length + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Closed,
            Paused,
            Retry,
            Pending,
        }
    }
}
